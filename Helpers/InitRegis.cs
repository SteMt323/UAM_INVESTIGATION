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
            UsuarioEst usuarioConId = new UsuarioEst(nuevoUsuario.Id, nuevoUsuario.Nombre, nuevoUsuario.Correo, nuevoUsuario.Cif, nuevoUsuario.Contrasenia, nuevoUsuario.Carrera, nuevoUsuario.Estado);
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
                    sw.WriteLine($"{usuarioConId.Id}|{usuarioConId.Nombre}|{usuarioConId.Correo}|{usuarioConId.Cif}|{usuarioConId.Contrasenia}|{usuarioConId.Carrera}|{usuarioConId.Estado}");
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

            // Crear un nuevo objeto UsuarioAdmin con el Id generado
            UsuarioAdmin adminConId = new UsuarioAdmin(nuevoAdmin.Id, nuevoAdmin.Nombre, nuevoAdmin.Correo, nuevoAdmin.Contrasenia);

            // Verificamos si existe el archivo
            if (!File.Exists(usuarioAdminFile))
            {
                File.Create(usuarioAdminFile).Close();
            }

            // Guardamos el usuario en el archivo
            try
            {
                using (StreamWriter sw = new StreamWriter(usuarioAdminFile, true))
                {
                    sw.WriteLine($"{adminConId.Id}|{adminConId.Nombre}|{adminConId.Correo}|{adminConId.Contrasenia}");
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
        public List<UsuarioEst> LeerUsuariosEst()
        {
            var usuarios = new List<UsuarioEst>();
            try
            {
                if (File.Exists(usuarioEstFile))
                {
                    foreach (var linea in File.ReadLines(usuarioEstFile))
                    {
                        var datos = linea.Split('|');
                        int id = int.Parse(datos[0]);
                        bool estado = bool.Parse(datos[6]);
                        usuarios.Add(new UsuarioEst(id, datos[1], datos[2], datos[3], datos[4], datos[5], estado));
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
        public List<UsuarioAdmin> LeerUsuariosAdmin()
        {
            var admins = new List<UsuarioAdmin>();
            try
            {
                if (File.Exists(usuarioAdminFile))
                {
                    foreach (var linea in File.ReadLines(usuarioAdminFile))
                    {
                        var datos = linea.Split('|');

                        // Asumimos que el primer dato es el Id, y el resto los demás campos
                        int id = int.Parse(datos[0]);  // Leer el Id

                        // Crear el objeto UsuarioAdmin con el Id
                        admins.Add(new UsuarioAdmin(id, datos[1], datos[2], datos[3]));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al acceder al archivo: {ex.Message}");
            }

            return admins;
        }


        public bool CorreoExistenteEnEstudiantes(string correo)
        {
            foreach(var usuario in LeerUsuariosEst())
            {
                if (usuario.Correo == correo)
                {
                    return true; // El correo ya está registrado
                }
            }
            return false;
        }

        public bool CorreoExisteEnAdmins(string correo)
        {
            foreach (var admin in LeerUsuariosAdmin())
            {
                if (admin.Correo == correo)
                {
                    return true;  // El correo ya está registrado
                }
            }
            return false;
        }

        public void ActualizarUsuarioAdmin(int id, string nuevoNombre, string nuevoCorreo, string nuevaContrasenia)
        {
            var admins = LeerUsuariosAdmin(); // Leer todos los administradores

            // Buscar el administrador que queremos actualizar
            for (int i = 0; i < admins.Count; i++)
            {
                if (admins[i].Id == id) // Encontramos el administrador por ID
                {
                    // Crear un nuevo objeto con los datos actualizados
                    admins[i] = new UsuarioAdmin(id, nuevoNombre, nuevoCorreo, nuevaContrasenia);
                    break; // Salimos del bucle una vez hecho el cambio
                }
            }

            // Sobreescribir el archivo con los datos actualizados
            try
            {
                using (StreamWriter sw = new StreamWriter(usuarioAdminFile))
                {
                    foreach (var admin in admins)
                    {
                        sw.WriteLine($"{admin.Id}|{admin.Nombre}|{admin.Correo}|{admin.Contrasenia}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al escribir en el archivo: {ex.Message}");
            }
        }

        //Dar baja Usuarios Estudiantes
        public void DarDeBajaUsuario(int id)
        {
            var estudiantes = LeerUsuariosEst();

            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].Id == id)
                {
                    estudiantes[i] = new UsuarioEst
                    {
                        Id = estudiantes[i].Id,
                        Nombre = estudiantes[i].Nombre,
                        Correo = estudiantes[i].Correo,
                        Cif = estudiantes[i].Cif,
                        Contrasenia = estudiantes[i].Contrasenia,
                        Carrera = estudiantes[i].Carrera,
                        Estado = false // Cambiamos el estado a "dado de baja"
                    };
                    break;
                }
            }

            // Sobreescribir el archivo
            using (StreamWriter sw = new StreamWriter(usuarioEstFile))
            {
                foreach (var est in estudiantes)
                {
                    sw.WriteLine($"{est.Id}|{est.Nombre}|{est.Correo}|{est.Cif}|{est.Contrasenia}|{est.Carrera}|{est.Estado}");
                }
            }
        }

    }
}
