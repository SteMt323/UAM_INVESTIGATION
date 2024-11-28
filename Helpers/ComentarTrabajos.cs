using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAM_INVESTIGATION.Estructuras;

namespace UAM_INVESTIGATION.Helpers
{
    
    internal class ComentarTrabajos
    {
        private readonly string folderPath;
        private readonly string comentariosFile;

        public ComentarTrabajos()
        {
            // Obtener la ruta de la carpeta principal del proyecto
            folderPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Archivos");

            // Crear la carpeta "Archivos" si no existe
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Inicializar las rutas de archivo
            comentariosFile = Path.Combine(folderPath, "Comentarios.txt");
        }

        //Agregar comentario
        public void AgregarComentario(Comentario comentario)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(comentariosFile, true))
                {
                    sw.WriteLine($"{comentario.IdComentario}|{comentario.IdUsuario}|{comentario.IdTrabajo}|{comentario.TextoComentario}");
                }

            }catch(IOException ex)
            {
                throw new Exception($"Error al agregar el comentario: {ex.Message}");
            }
        }

        //Leer Comentarios
        public List <Comentario> LeerComenarios()
        {
            var comentarios = new List<Comentario>();
            try
            {
                if(File.Exists(comentariosFile))
                {
                    foreach (var linea in File.ReadAllLines(comentariosFile))
                    {
                        var datos = linea.Split('|');
                        int idComentario = int.Parse(datos[0]);
                        int idUsuario = int.Parse(datos[1]);
                        int idTrabajo = int.Parse(datos[2]);
                        comentarios.Add(new Comentario(idComentario, idUsuario, idTrabajo, datos[3]));
                    }
                }
            }catch (IOException ex)
            {
                throw new Exception($"Error al leer los comenatarios: {ex.Message}");
            }
            return comentarios;
        }

        public void ActualizarComentarios(int idUsuario, int idTrabajo, string nuevoComenatio)
        {
            
                var comentarios = LeerComenarios();

                for (int i = 0; i < comentarios.Count; i++)
                {
                    //Buscar el comenatario del usuario (si es que ya comenato)
                    if (comentarios[i].IdUsuario == idUsuario && comentarios[i].IdTrabajo == idTrabajo)
                    {
                        comentarios[i] = new Comentario(comentarios[i].IdComentario, comentarios[i].IdUsuario, comentarios[i].IdTrabajo, nuevoComenatio);
                        break;
                    }
                }

            try
            {
                //Guardar los comentarios actualizados
                using (StreamWriter sw = new StreamWriter(comentariosFile, false))
                {
                    foreach (var comentario in comentarios)
                    {
                        sw.WriteLine($"{comentario.IdComentario}|{comentario.IdUsuario}|{comentario.IdTrabajo}|{nuevoComenatio}");
                    }
                }
            }catch(IOException ex)
            {
                throw new Exception($"Error al actualizar los comentarios: {ex.Message}");
            }
        }
    }
}
