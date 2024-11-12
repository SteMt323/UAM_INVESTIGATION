using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM_INVESTIGATION.Estructuras
{
    public struct UsuarioAdmin
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }

        public UsuarioAdmin(string nombre, string correo, string contrasenia)
        {
            Random random = new Random();
            Id = random.Next(1000, 9999); //Generara un id al azar
            Nombre = nombre;
            Correo = correo;
            Contrasenia = contrasenia;
        }
    }
}
