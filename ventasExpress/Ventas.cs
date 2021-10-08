using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventasExpress
{
    class Ventas
    {
        protected string codproduct;
        protected string nomproduct;
        protected int cantproduct;

        public string Codproducto
        {
            get { return codproduct; }
            set { codproduct = value; }
        }

        public string Nomproduct
        {
            get { return nomproduct; }
            set { nomproduct = value; }
        }

        public int Cantproduct
        {
            get { return cantproduct; }
            set { cantproduct = value; }
        }
    }
}
