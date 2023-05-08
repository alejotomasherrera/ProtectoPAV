using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Entidades
{
    public class Usuario
    {
        private string nombreUsu;
        private string Pass;

        public Usuario(string nombreUsuario, string password)
        {
            nombreUsu = nombreUsuario;
            Pass = password;
        }

        public string NombreDeUsuario
        {
            get => nombreUsu;
            set => nombreUsu = value;
        }
        public string Password
        {
            get => Pass;
            set => Pass = value;
        }

    }

}
