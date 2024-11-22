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
                //Generar un nuevo ID basado en la cantidad de trabajos registrados
                int idTrabajo = trabajos.Count + 1;

                //Generar el nombre del archivo PDF basado en el ID del trabajo
                string archivoDestinoPdf = Path.Combine(carpetaDestinoPdf, $"{idTrabajo}.pdf");

                //Guardar Estado en Vigente
                bool estado = true;

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
                    archivoDestinoPdf,
                    estado
                );

                // Agregar el nuevo trabajo a la lista
                trabajos.Add(nuevoTrabajo);

                // Guardar el registro en el archivo "Trabajos.txt"
                string registro = $"{idTrabajo}|{idUsuario}|{titulo}|{descripcion}|{categoria}|{DateTime.Now}|{archivoDestinoPdf}|{estado}";
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
                            campos[6],
                            bool.Parse(campos[7])
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
            return trabajos.FirstOrDefault(t => t.IdTrabajo == idTrabajo && t.Estado);
        }

        public void ActualizarTrabajo(int idTrabajo, string titulo, string descripcion, string categoria)
        {
            var trabajos = ObtenerTrabajos();
            for (int i = 0; i < trabajos.Count; i++)
            {
                if (trabajos[i].IdTrabajo == idTrabajo)
                {
                    // Reemplazar el trabajo encontrado con los nuevos datos
                    trabajos[i] = new StrTrabajos
                    {
                        IdTrabajo = idTrabajo,
                        IdUsuario = trabajos[i].IdUsuario, // Mantener el mismo IdUsuario
                        Titulo = titulo,
                        Descripcion = descripcion,
                        Categoria = categoria,
                        FechaSubida = trabajos[i].FechaSubida, // Mantener la fecha original
                        RutaArchivo = trabajos[i].RutaArchivo, // Mantener la ruta original
                        Estado = trabajos[i].Estado
                    };
                    break;
                }
            }

            // Guardar los cambios en el archivo
            try
            {
                using (StreamWriter sw = new StreamWriter(archivoTrabajos))
                {
                    foreach (var trabajo in trabajos)
                    {
                        sw.WriteLine($"{trabajo.IdTrabajo}|{trabajo.IdUsuario}|{trabajo.Titulo}|{trabajo.Descripcion}|{trabajo.Categoria}|{trabajo.FechaSubida:O}|{trabajo.RutaArchivo}|{trabajo.Estado}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al escribir en el archivo: {ex.Message}");
            }
        }

        public void EliminarTrabajo(int idTrabajo)
        {
            var trabajos = ObtenerTrabajos();
            for (int i = 0; i < trabajos.Count; i++)
            {
                if (trabajos[i].IdTrabajo == idTrabajo)
                {
                    // Cambiar el estado del trabajo a inactivo (Estado = false)
                    trabajos[i] = new StrTrabajos
                    {
                        IdTrabajo = trabajos[i].IdTrabajo,
                        IdUsuario = trabajos[i].IdUsuario,
                        Titulo = trabajos[i].Titulo,
                        Descripcion = trabajos[i].Descripcion,
                        Categoria = trabajos[i].Categoria,
                        FechaSubida = trabajos[i].FechaSubida,
                        RutaArchivo = trabajos[i].RutaArchivo,
                        Estado = false // Marcar como inactivo
                    };
                    break;
                }
            }

            // Guardar los cambios en el archivo
            try
            {
                using (StreamWriter sw = new StreamWriter(archivoTrabajos))
                {
                    foreach (var trabajo in trabajos)
                    {
                        sw.WriteLine($"{trabajo.IdTrabajo}|{trabajo.IdUsuario}|{trabajo.Titulo}|{trabajo.Descripcion}|{trabajo.Categoria}|{trabajo.FechaSubida:O}|{trabajo.RutaArchivo}|{trabajo.Estado}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al escribir en el archivo: {ex.Message}");
            }
        }
    }
}

