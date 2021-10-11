using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventasExpress
{
    public class Ventas
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

    class Factura
    {

        protected string tipoproducto;
        protected int cantproducto;
        protected double precioproduct;
        protected double precioTXproducto;
        protected double total;

        public string TipoProducto
        {
            get { return tipoproducto; }
            set { tipoproducto = value; }
        }

        public int xCantProducto
        {
            get { return cantproducto; }
            set { cantproducto = value; }
        }

        public double PrecioProducto
        {
            get { return precioproduct; }
            set { precioproduct = value; }
        }

        public double PrecioTXProducto
        {
            get { return precioTXproducto; }
            set { precioTXproducto = value; }
        }
        
        public double TotalFactura
        {
            get { return total; }
            set { total = value; }
        }

        


    }

}
