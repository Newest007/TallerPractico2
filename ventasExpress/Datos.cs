using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventasExpress
{
    class Datos
    {
        protected string cuenta; //Va a ser la variable que almacenará al usuario
        protected string contraseña;
        
        public string Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }
        
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        } 

    }
}
