using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ventasExpress
{
    public partial class FrmMenu : ventasExpress.FrmBase
    {
        private List<Ventas> Productos = new List<Ventas>(); //Esta será la lista en la que estarán los productos
        DataTable ListaProductos = new DataTable();
        //Creamos una data table para poder mostrar la lista en el DataGriedView

        private void LlenarGrid(List<Ventas> Productos) //Este procedimiento se encargará de poner los datos del DataTable al DGV
        {
            ListaProductos.Rows.Clear();
            foreach (Ventas v in Productos)
            {
                ListaProductos.Rows.Add(v.Codproducto, v.Nomproduct, v.Cantproduct);
            }
            Dgvproductos.DataSource = null;
            Dgvproductos.DataSource = ListaProductos;
        }

        public FrmMenu()
        {
            InitializeComponent();

            //Agregamos los datos a la lista "Productos"
            Productos.Add(new Ventas { Codproducto = "1", Nomproduct = "huevos", Cantproduct = 30 });
            Productos.Add(new Ventas { Codproducto = "2", Nomproduct = "pollo", Cantproduct = 10 });
            Productos.Add(new Ventas { Codproducto = "3", Nomproduct = "aceite", Cantproduct = 50 });
            Productos.Add(new Ventas { Codproducto = "4", Nomproduct = "fósforos", Cantproduct = 200 });
            Productos.Add(new Ventas { Codproducto = "5", Nomproduct = "dulces", Cantproduct = 500 });
            Productos.Add(new Ventas { Codproducto = "6", Nomproduct = "margarina", Cantproduct = 30 });
            Productos.Add(new Ventas { Codproducto = "7", Nomproduct = "jabón", Cantproduct = 25 });
            Productos.Add(new Ventas { Codproducto = "8", Nomproduct = "carne", Cantproduct = 35 });
            Productos.Add(new Ventas { Codproducto = "9", Nomproduct = "gaseosa", Cantproduct = 200 });
            Productos.Add(new Ventas { Codproducto = "10", Nomproduct = "desechables", Cantproduct = 800 });

            //Ahora añadimos columnas al DataTable
            ListaProductos.Columns.Add(new DataColumn("Codproduct", typeof(string)));
            ListaProductos.Columns.Add(new DataColumn("Nomproduct", typeof(string)));
            ListaProductos.Columns.Add(new DataColumn("Cantproduct", typeof(int)));

            //Mandamos la lista para que la muestre en el DGV
            //LlenarGrid(Productos);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void labelbienvenida_Click(object sender, EventArgs e)
        {

        }

        private void txtconsult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnacceder_Click(object sender, EventArgs e) //Configuramos el boton que hará de buscador
        {
            string productobuscar = txtconsult.Text.Trim();
            if (productobuscar.ToUpper() == "TODOS")
            {
                LlenarGrid(Productos);
                return;
            }
            List<Ventas> lista = new List<Ventas>();
            foreach (Ventas v in Productos)
            {
                if (String.Concat(v.Codproducto, v.Nomproduct).ToUpper().Contains(productobuscar.ToUpper()))
                {
                    lista.Add(v);
                }

            }

            LlenarGrid(lista);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
