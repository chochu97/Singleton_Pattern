using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLibrary
{
    public class SessionManager
    {
        private static SessionManager _session;
        private static object _lock = new Object();

        public Usuario Usuario { get; set; }
        public DateTime FechaInicio { get; set; }


        public static SessionManager GetInstance
        {
            get
            {
                return _session;
            }
        }



        public static void Login(Usuario user)
        {
            lock (_lock)
            {
                if (_session == null)
                {
                    _session = new SessionManager();
                    _session.Usuario = user;
                    _session.FechaInicio = DateTime.Now;
                }
                else
                {
                    throw new Exception("Sesion ya iniciada");
                }
            }

        }

        public static void LogOut()
        {
            lock (_lock)
            {
                if (_session != null)
                {
                    _session = null;
                }
                else
                {
                    throw new Exception("No hay sesion iniciada");
                }
            }

        }
        private SessionManager()
        {

        }
    }
}
