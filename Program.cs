using SingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();

            /*Console.WriteLine("Ingrese el nombre de usuario:  ");
            usuario.Username = Console.ReadLine();

            Console.WriteLine("Ingrese la contraseña:  ");
            usuario.Password = Console.ReadLine();*/

            usuario.Username = "prueba";
            usuario.Password = "prueba2";
            
            try
            {
                SessionManager.Login(usuario);

                SessionManager u = SessionManager.GetInstance;

                SessionManager.LogOut();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
