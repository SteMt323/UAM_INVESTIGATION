using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UAM_INVESTIGATION.Estructuras;

namespace UAM_INVESTIGATION.Helpers
{
    internal class ControlTrabajos
    {
        private readonly string carpetaDestinoPdf = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Trabajos Investigativos");
        private readonly string carpetaArchivosTxt = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Archivos");
        private readonly string archivoTrabajos = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Archivos", "Trabajos.txt");

        private List<StrTrabajos> trabajos;

        public ControlTrabajos()
        {
            // Crear las carpetas necesarias si no existen
            if (!Directory.Exists(carpetaDestinoPdf))
                Directory.CreateDirectory(carpetaDestinoPdf);

            if (!Directory.Exists(carpetaArchivosTxt))
                Directory.CreateDirectory(carpetaArchivosTxt);

            // Crear el archivo de texto si no existe
            if (!File.Exists(archivoTrabajos))
                File.Create(archivoTrabajos).Close();

            trabajos = new List<StrTrabajos>();
        }

        public bool GuardarTrabajo(int idUsuario, string titulo, string descripcion, string categoria, string archivoPdf)
        {
            try
            {
                // Generar un nuevo ID basado en la cantidad de trabajos registrados
                int idTrabajo = trabajos.Count + 1;

                // Generar el nombre del archivo PDF basado en el ID del trabajo
                string archivoDestinoPdf = Path.Combine(carpetaDestinoPdf, $"{idTrabajo}.pdf");

                // Copiar el archivo PDF a la carpeta "Trabajos Investigativos"
                File.Copy(archivoPdf, archivoDestinoPdf, overwrite: true);

                // Crear el objeto del nuevo trabajo
                StrTrabajos nuevoTrabajo = new StrTrabajos
                (
                    idTrabajo,
                    idUsuario,
                    titulo,
                    descripcion,
                    categoria,
                    DateTime.Now,
                    new Comentario(),
                    new Valoracion(),
                    archivoDestinoPdf
                );

                // Agregar el nuevo trabajo a la lista
                trabajos.Add(nuevoTrabajo);

                // Guardar el registro en el archivo "Trabajos.txt"
                string registro = $"{idTrabajo}|{idUsuario}|{titulo}|{descripcion}|{categoria}|{DateTime.Now}|{archivoDestinoPdf}";
                File.AppendAllText(archivoTrabajos, registro + Environment.NewLine);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el trabajo: {ex.Message}");
                return false;
            }
        }

        public List<StrTrabajos> ObtenerTrabajos()
        {
            try
            {
                // Leer los registros desde el archivo "Trabajos.txt"
                if (File.Exists(archivoTrabajos))
                {
                    string[] lineas = File.ReadAllLines(archivoTrabajos);

                    trabajos = lineas.Select(linea =>
                    {
                        var campos = linea.Split('|');
                        return new StrTrabajos(
                            int.Parse(campos[0]),
                            int.Parse(campos[1]),
                            campos[2],
                            campos[3],
                            campos[4],
                            DateTime.Parse(campos[5]),
                            new Comentario(), // Asumimos que los comentarios y valoraciones se cargan luego
                            new Valoracion(),
                            campos[6]
                        );
                    }).ToList();
                }
                return trabajos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener trabajos: {ex.Message}");
                return new List<StrTrabajos>();
            }
        }

        public StrTrabajos BuscarTrabajo(int idTrabajo)
        {
            return trabajos.FirstOrDefault(t => t.IdTrabajo == idTrabajo);
        }

        public bool ActualizarTrabajo(int idTrabajo, string titulo, string descripcion, string categoria)
        {
            try
            {
                var trabajo = trabajos.FirstOrDefault(t => t.IdTrabajo == idTrabajo);
                if (trabajo.Equals(default(StrTrabajos)))
                    return false;

                trabajo.Titulo = titulo;
                trabajo.Descripcion = descripcion;
                trabajo.Categoria = categoria;

                // Actualizar el archivo "Trabajos.txt"
                ActualizarArchivoTxt();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el trabajo: {ex.Message}");
                return false;
            }
        }

        public bool EliminarTrabajo(int idTrabajo)
        {
            try
            {
                var trabajo = trabajos.FirstOrDefault(t => t.IdTrabajo == idTrabajo);
                if (trabajo.Equals(default(StrTrabajos)))
                    return false;

                trabajos.Remove(trabajo);

                // Actualizar el archivo "Trabajos.txt"
                ActualizarArchivoTxt();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el trabajo: {ex.Message}");
                return false;
            }
        }

        private void ActualizarArchivoTxt()
        {
            try
            {
                var registros = trabajos.Select(t =>
                    $"{t.IdTrabajo}|{t.IdUsuario}|{t.Titulo}|{t.Descripcion}|{t.Categoria}|{t.FechaSubida}|{t.RutaArchivo}"
                );
                File.WriteAllLines(archivoTrabajos, registros);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el archivo de texto: {ex.Message}");
            }
        }
    }
}

