using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM_INVESTIGATION.Estructuras
{

    public struct Valoracion
    {
        public int IdCalificacion { get; set; }
        public int IdTrabajo { get; set; }
        public int IdUsuario { get; set; }
        public int Calificacion {  get; set; }

        public Valoracion(int idCalificacion, int idTrabajo, int idUsuario, int calificacion)
        {
            IdCalificacion = idCalificacion;
            IdTrabajo = idTrabajo;
            IdUsuario = idUsuario;
            Calificacion = calificacion;
        }
    }
    public struct Comentario
    {
        public int IdComentario { get; set; }
        public int IdUsuario { get; set; }
        public int IdTrabajo { get; set; }
        public string TextoComentario { get; set; }

        public Comentario(int idComentario, int idUsuario, int idTrabajo, string textoComentario)
        {
            IdComentario = idComentario;
            IdUsuario = idUsuario;
            IdTrabajo = idTrabajo;
            TextoComentario = textoComentario;
        }
    }

    public struct StrTrabajos
    {
        public int IdTrabajo { get; set; }
        public int IdUsuario { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaSubida { get; set; }
        public string RutaArchivo { get; set; }
        public bool Estado { get; set; }

        public StrTrabajos(int idTrabajo, int idUsuario, string nombreTitulo, string descripcion, string categoria, DateTime fechaSubida, string rutaArchivo, bool estado)
        {
            IdTrabajo = idTrabajo;
            IdUsuario = idUsuario;
            Titulo = nombreTitulo;
            Descripcion = descripcion;
            Categoria = categoria;
            FechaSubida = fechaSubida;
            RutaArchivo = rutaArchivo;
            Estado = estado;
        }
    }

}
