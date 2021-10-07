using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventasExpress
{
    class UsuarioEncriptado //Esta clase guardará los datos ya encriptados
    {
        protected string usuarioencript; //Aqui se almacenarán los usuarios ya encriptados
        protected string contraencript;  //Aquí se almacenarán las contraseñas ya encriptadas

        public string Usuarioencript
        {
            get { return usuarioencript; }
            set { usuarioencript = value; }
        }

        public string Contraencript
        {
            get { return contraencript; }
            set { contraencript = value; }
        }
    }
}
