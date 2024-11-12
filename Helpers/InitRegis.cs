using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using UAM_INVESTIGATION.Estructuras;

namespace UAM_INVESTIGATION.Helpers
{
    internal class InitRegis
    {
        private readonly string usuarioEstFile = "usuariosEst.txt";
        private readonly string usuarioAdminFile = "usuariosAdmin.txt";

        //Constructor
        public InitRegis() { }

        //Registrar UsuarioEst
        public void RegistrarUsuarioEst(UsuarioEst nuevoUsuario)
        {
            //Verificamos si existe el archivo
            if (!File.Exists(usuarioEstFile))
            {
                File.Create(usuarioEstFile).Close();
            }
            //Guardaremos el usuario en el archivo
            try
            {
                using (StreamWriter sw = new StreamWriter(usuarioEstFile, true))
                {
                    sw.WriteLine($"{nuevoUsuario.Id}|{nuevoUsuario.Nombre}|{nuevoUsuario.Correo}|{nuevoUsuario.Cif}|{nuevoUsuario.Contrasenia}|{nuevoUsuario.Carrera}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al acceder al archivo: {ex.Message}");
            }

        }

        //Registrar UsuarioAdmin
        public void RegistrarUsuarioAdmin(UsuarioAdmin nuevoAdmin)
        {
            if (!File.Exists(usuarioAdminFile))
            {
                File.Create(usuarioAdminFile).Close();
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(usuarioAdminFile, true))
                {
                    sw.WriteLine($"{nuevoAdmin.Id}|{nuevoAdmin.Nombre}|{nuevoAdmin.Correo}|{nuevoAdmin.Contrasenia}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al acceder al archivo: {ex.Message}");
            }

        }

        //Inicio de Sesión Estudiantes
        public bool IniciarSesionEstCorreo(string correo, string contrasenia)
        {
            //Verificar en los usuarios estudiantes
            foreach (var usuario in LeerUsuariosEst())
            {
                if (usuario.Correo == correo && usuario.Contrasenia == contrasenia)
                {
                    return true;
                }
                if (usuario.Correo != correo && usuario.Contrasenia != contrasenia)
                {
                    Console.WriteLine("Las credenciales son incorrectas, por favor intente denuevo...");
                    return false;
                }
                if (usuario.Correo != correo)
                {
                    Console.WriteLine("El correo es inválido, por favor intente denuevo...");
                    return false;
                }

                if (usuario.Contrasenia != contrasenia)
                {
                    Console.WriteLine("La contraseña es inválida, por favor intente denuevo...");
                    return false;
                }
            }
            return false;
        }

        public bool IniciarSesionEstCif(string cif, string contrasenia)
        {
            //Verificar en los usuarios estudiantes
            foreach (var usuario in LeerUsuariosEst())
            {
                if (usuario.Cif == cif && usuario.Contrasenia == contrasenia)
                {
                    return true;
                }
                if (usuario.Cif != cif && usuario.Contrasenia != contrasenia)
                {
                    Console.WriteLine("Las credenciales son incorrectas, por favor intente denuevo...");
                    return false;
                }
                if (usuario.Cif != cif)
                {
                    Console.WriteLine("El correo es inválido, por favor intente denuevo...");
                    return false;
                }
                if (usuario.Contrasenia != contrasenia)
                {
                    Console.WriteLine("La contraseña es inválida, por favor intente denuevo...");
                    return false;
                }
            }
            return false;
        }

        //Inicio dee Sesión Admin
        public bool IniciarSesionAdmin(string correo, string contrasenia)
        {
            //Verificar en los usuarios estudiantes
            foreach (var usuario in LeerUsuariosAdmin())
            {
                if (usuario.Correo == correo && usuario.Contrasenia == contrasenia)
                {
                    return true;
                }
                if (usuario.Correo != correo && usuario.Contrasenia != contrasenia)
                {
                    Console.WriteLine("Las credenciales son incorrectas, por favor intente denuevo...");
                    return false;
                }
                if (usuario.Correo != correo)
                {
                    Console.WriteLine("El correo es inválido, por favor intente denuevo...");
                    return false;
                }
                if (usuario.Contrasenia != contrasenia)
                {
                    Console.WriteLine("La contraseña es inválida, por favor intente denuevo...");
                    return false;
                }
            }
            return false;
        }

        //Método para leer usuarios de estudiantes
        private List<UsuarioEst> LeerUsuariosEst()
        {
            var usuarios = new List<UsuarioEst>();
            try
            {
                if (File.Exists(usuarioEstFile))
                {
                    foreach (var linea in File.ReadLines(usuarioEstFile))
                    {
                        var datos = linea.Split('|');
                        usuarios.Add(new UsuarioEst(datos[1], datos[2], datos[3], datos[4], datos[5]));
                    }

                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al acceder al archivo: {ex.Message}");
            }

            return usuarios;
        }

        //Método para leer usuarios Administradores
        private List<UsuarioAdmin> LeerUsuariosAdmin()
        {
            var admins = new List<UsuarioAdmin>();
            try
            {
                if (File.Exists(usuarioAdminFile))
                {
                    foreach (var linea in File.ReadLines(usuarioAdminFile))
                    {
                        var datos = linea.Split('|');
                        admins.Add(new UsuarioAdmin(datos[1], datos[2], datos[3]));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al acceder al archivo: {ex.Message}");
            }

            return admins;
        }
    }
}
