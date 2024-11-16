using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM_INVESTIGATION.Estructuras
{
    public struct UsuarioEst
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Cif { get; set; }
        public string Contrasenia { get; set; }
        public string Carrera { get; set; }
        public bool Estado { get; set; }

        public UsuarioEst(int id, string nombre, string correo, string cif, string contrasenia, string carrera, bool estado)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            Cif = cif;
            Contrasenia = contrasenia;
            Carrera = carrera;
            Estado = estado;
        }
    }
}
