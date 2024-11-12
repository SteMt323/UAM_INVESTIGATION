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

        public UsuarioEst(string nombre, string correo, string cif, string contrasenia, string carrera)
        {
            Random random = new Random();
            Id = random.Next(1000, 9999); //Generara un id al azar
            Nombre = nombre;
            Correo = correo;
            Cif = cif;
            Contrasenia = contrasenia;
            Carrera = carrera;
        }
    }
}
