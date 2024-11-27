using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAM_INVESTIGATION.Estructuras;

namespace UAM_INVESTIGATION.Helpers
{
    internal class ValorarTrabajos
    {
        private readonly string folderPath;
        private readonly string valoracionesFile;

        public ValorarTrabajos()
        {
            // Obtener la ruta de la carpeta principal del proyecto
            folderPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Archivos");

            // Crear la carpeta "Archivos" si no existe
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Inicializar las rutas de archivo
            valoracionesFile = Path.Combine(folderPath, "Valoraciones.txt");
        }

        //Agregar valoracion
        public void AgregarValoracion(Valoracion valoracion)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(valoracionesFile, true))
                {
                    sw.WriteLine($"{valoracion.IdCalificacion}|{valoracion.IdTrabajo}|{valoracion.IdUsuario}|{valoracion.Calificacion}");
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al agregar la valoración: {ex.Message}");
            }
        }

        //Leer Valoraciones y devolverlos mediante una lista
        public List <Valoracion> LeerValoraciones()
        {
            var valoraciones = new List<Valoracion>();
            try
            {
                if (File.Exists(valoracionesFile))
                {
                    foreach (var linea in File.ReadAllLines(valoracionesFile))
                    {
                        var datos = linea.Split('|');
                        int idCalificacion = int.Parse(datos[0]);
                        int idTrabajo = int.Parse(datos[1]);
                        int idUsuario = int.Parse(datos[2]);
                        int calificacion = int.Parse(datos[3]);
                        valoraciones.Add(new Valoracion(idCalificacion, idTrabajo, idUsuario, calificacion));
                    }
                }

            }catch(IOException ex)
            {
                throw new Exception($"Error al leer las valoraciones: {ex.Message}");
            }
            return valoraciones;
        }

        //Actualizar Valoraciones
        public void ActualizarValoraciones(int idUsuario, int idTrabajo, int nuevaCalificacion)
        {
            try
            {
                var valoraciones = LeerValoraciones();
                bool encontrado = false;

                for (int i = 0; i < valoraciones.Count; i++)
                {
                    //Buscar la valoracion del usuario
                    if (valoraciones[i].IdUsuario == idUsuario && valoraciones[i].IdTrabajo == idTrabajo)
                    {
                        valoraciones[i] = new Valoracion(valoraciones[i].IdCalificacion, valoraciones[i].IdTrabajo, valoraciones[i].IdUsuario, nuevaCalificacion);
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado) throw new Exception("No se encontró la valoración con el ID especificado.");

                //Guardar las valoraciones actualizadas en el archivo
                using (StreamWriter sw = new StreamWriter(valoracionesFile, false))
                {
                    foreach (var valoracion in valoraciones)
                    {
                        sw.WriteLine($"{valoracion.IdCalificacion}|{valoracion.IdTrabajo}|{valoracion.IdUsuario}|{valoracion.Calificacion}");
                    }
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al actualizar las valoraciones: {ex.Message}");
            }
        }
    }
}
