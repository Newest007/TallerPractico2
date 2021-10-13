using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace ventasExpress
{
    public partial class FrmMenu : ventasExpress.FrmBase
    {
        public List<Ventas> Productos = new List<Ventas>(); //Esta será la lista en la que estarán los productos
        DataTable ListaProductos = new DataTable();
        //Creamos una data table para poder mostrar la lista en el DataGriedView

        private List<Factura> Facturas = new List<Factura>();
        DataTable ListaFacturas = new DataTable();

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

        private void LlenarGrid2(List<Factura> Facturas)
        {

            ListaFacturas.Rows.Clear();
            foreach(Factura v in Facturas)
            {
                ListaFacturas.Rows.Add(v.TipoProducto, v.xCantProducto, v.PrecioProducto, v.PrecioTXProducto, v.TotalFactura);
            }
            DtgvFactura.DataSource = null;
            DtgvFactura.DataSource = ListaFacturas;


        }

        public FrmMenu()
        {
            InitializeComponent();

            //Agregamos los datos a la lista "Productos"
            Productos.Add(new Ventas { Codproducto = "1", Nomproduct = "Huevos", Cantproduct = 30 });
            Productos.Add(new Ventas { Codproducto = "2", Nomproduct = "Pollo", Cantproduct = 10 });
            Productos.Add(new Ventas { Codproducto = "3", Nomproduct = "Aceite", Cantproduct = 50 });
            Productos.Add(new Ventas { Codproducto = "4", Nomproduct = "Fósforos", Cantproduct = 200 });
            Productos.Add(new Ventas { Codproducto = "5", Nomproduct = "Dulces", Cantproduct = 500 });
            Productos.Add(new Ventas { Codproducto = "6", Nomproduct = "Margarina", Cantproduct = 30 });
            Productos.Add(new Ventas { Codproducto = "7", Nomproduct = "Jabón", Cantproduct = 25 });
            Productos.Add(new Ventas { Codproducto = "8", Nomproduct = "Carne", Cantproduct = 35 });
            Productos.Add(new Ventas { Codproducto = "9", Nomproduct = "Gaseosa", Cantproduct = 200 });
            Productos.Add(new Ventas { Codproducto = "10", Nomproduct = "Desechables", Cantproduct = 800 });

            //Ahora añadimos columnas al DataTable
            ListaProductos.Columns.Add(new DataColumn("Codproduct", typeof(string)));
            ListaProductos.Columns.Add(new DataColumn("Nomproduct", typeof(string)));
            ListaProductos.Columns.Add(new DataColumn("Cantproduct", typeof(int)));

            ListaFacturas.Columns.Add(new DataColumn("Tipo de Producto", typeof(string)));
            ListaFacturas.Columns.Add(new DataColumn("Cantidad", typeof(int)));
            ListaFacturas.Columns.Add(new DataColumn("Precio c/u ", typeof(double)));
            ListaFacturas.Columns.Add(new DataColumn("Precio Total c/u", typeof(double)));
            ListaFacturas.Columns.Add(new DataColumn("Total a Pagar", typeof(double)));
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
            txtconsult.Clear();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter escritor = null;
            escritor = File.CreateText("ListaCompras.txt");
            var listaCompras = txtcomprar.Text;
            escritor.WriteLine(listaCompras);
            escritor.Flush();

            char delimitador = ',';
            string[] valores = listaCompras.Split(delimitador);
            int tamaño = valores.Length;

            double ventatotal, producto;
            ventatotal = 0;
            producto = 1;

            string tipoproducto;
            tipoproducto = "";

            try
            {

                for (int x = 0; x < valores.Length; x++)
                {

                    //Tipo de Producto
                    if (valores[x] == "1.")
                    {
                        producto = 0.10;
                        tipoproducto = "Huevos";
                        
                    }

                    if (valores[x] == "2.")
                    {
                        producto = 5.00;
                        tipoproducto = "Pollo";
                    }

                    if (valores[x] == "3.")
                    {
                        producto = 3.00;
                        tipoproducto = "Aceite";
                    }

                    if (valores[x] == "4.")
                    {
                        producto = 0.50;                        
                        tipoproducto = "Fósforos";
                    }

                    if (valores[x] == "5.")
                    {
                        producto = 0.80;                        
                        tipoproducto = "Dulces";
                    }

                    if (valores[x] == "6.")
                    {
                        producto = 0.30;                        
                        tipoproducto = "Margarina";
                    }

                    if (valores[x] == "7.")
                    {
                        producto = 2.25;                        
                        tipoproducto = "Jabón";
                    }

                    if (valores[x] == "8.")
                    {
                        producto = 2.75;                        
                        tipoproducto = "Carne";
                    }

                    if (valores[x] == "9.")
                    {
                        producto = 1.80;                        
                        tipoproducto = "Gaseosa";
                    }

                    if (valores[x] == "10.")
                    {
                        producto = 3.25;                        
                        tipoproducto = "Desechables";
                    }

                    //NumeroProductos
                    if (valores[x] == "1")
                    {
                        ventatotal = ventatotal + (producto * 1);
                        Facturas.Add(new Factura { TipoProducto = tipoproducto, PrecioProducto = producto ,xCantProducto = 1, PrecioTXProducto = (producto * 1)});
                    }

                    if (valores[x] == "2")
                    {
                        ventatotal = ventatotal + (producto * 2);
                        Facturas.Add(new Factura { TipoProducto = tipoproducto, PrecioProducto = producto ,xCantProducto = 2, PrecioTXProducto = (producto * 2)});
                    }

                    if (valores[x] == "3")
                    {
                        ventatotal = ventatotal + (producto * 3);
                        Facturas.Add(new Factura { TipoProducto = tipoproducto, PrecioProducto = producto, xCantProducto = 3, PrecioTXProducto = (producto * 3)});
                    }

                    if (valores[x] == "4")
                    {
                        ventatotal = ventatotal + (producto * 4);
                        Facturas.Add(new Factura { TipoProducto = tipoproducto, PrecioProducto = producto, xCantProducto = 4, PrecioTXProducto = (producto * 4)});
                    }

                    if (valores[x] == "5")
                    {
                        ventatotal = ventatotal + (producto * 5);
                        Facturas.Add(new Factura { TipoProducto = tipoproducto, PrecioProducto = producto, xCantProducto = 5, PrecioTXProducto = (producto * 5)});
                    }

                    if (valores[x] == "6")
                    {
                        ventatotal = ventatotal + (producto * 6);
                        Facturas.Add(new Factura {TipoProducto = tipoproducto, PrecioProducto = producto, xCantProducto = 6, PrecioTXProducto = (producto * 6)});
                    }

                    if (valores[x] == "7")
                    {
                        ventatotal = ventatotal + (producto * 7);
                        Facturas.Add(new Factura { TipoProducto = tipoproducto, PrecioProducto = producto, xCantProducto = 7, PrecioTXProducto = (producto * 7)});
                    }

                    if (valores[x] == "8")
                    {
                        ventatotal = ventatotal + (producto * 8);
                        Facturas.Add(new Factura { TipoProducto = tipoproducto, PrecioProducto = producto, xCantProducto = 8, PrecioTXProducto = (producto * 8)});
                    }

                    if (valores[x] == "9")
                    {
                        ventatotal = ventatotal + (producto * 9);
                        Facturas.Add(new Factura { TipoProducto = tipoproducto, PrecioProducto = producto, xCantProducto = 9, PrecioTXProducto = (producto * 9)});
                    }

                    if (valores[x] == "10")
                    {
                        ventatotal = ventatotal + (producto * 10);
                        Facturas.Add(new Factura { TipoProducto = tipoproducto, PrecioProducto = producto, xCantProducto = 10, PrecioTXProducto = (producto * 10)});
                    }

                    if (valores[x] == "")
                    {
                        ventatotal = 0;
                        MessageBox.Show("Es necesario ingresar su compra", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                MessageBox.Show("Imprimiendo su factura...", "Porfavor espere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (ventatotal > 20)
                {
                    ventatotal = ventatotal - (ventatotal * 0.03);
                    MessageBox.Show("Se le ha aplicado un descuento del 3%, pase feliz día!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                if(txtcomprar.Text.Contains("2."))
                {
                    if(txtcomprar.Text.Contains("9."))
                    {
                        MessageBox.Show("Se le han añadido de manera gratuita una cantidad de 5 dulces, disfrutelos!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Facturas.Add(new Factura { TipoProducto = "Dulces", xCantProducto = 5, PrecioProducto = 0.0, PrecioTXProducto = 0.0 });
                    }

                }

                

            }

            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch(Exception ex)
            {
                MessageBox.Show("Debe de introducir los datos tal y como se aconsejan"+ ex.Message);
            }

            Facturas.Add(new Factura { TotalFactura = ventatotal });
            LlenarGrid2(Facturas);

            txtcomprar.Clear();
            DtgvFactura.Visible = true;
            btnnewcompra.Visible = true;
            gbxcomprar.Visible = false;

            escritor.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DtgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnnewcompra_Click(object sender, EventArgs e)
        {
            gbxcomprar.Visible = true;
            btnnewcompra.Visible = false;
            DtgvFactura.Visible = false;

            Facturas.Clear();
        }

        public void btnchagepassword_Click(object sender, EventArgs e)
        {

            //Definimos las variables en las que se depositará la contraseña actual y la nueva
            string actualpassword;
            string newpassword;
            string confirmpassword;
           

            //Asignamos el origen de los datos que llenarán las variables creadas anteriormente
            actualpassword = txtactualpass.Text;
            newpassword = txtnewpassword.Text;
            confirmpassword = txtconfirmpassword.Text;



            //Creamos las soluciones para los casos que pueden ocurrir
            if (actualpassword == "" || newpassword == "" || confirmpassword == "")
            {
                MessageBox.Show("Debe de llenar todos campos para poder cambiar su contraseña n/Intente de nuevo");
                //limpiamos los espacios 
                limpiarcampos();
            }
            else
            {
                //Confirmamos que tanto la nueva contraseña como la coonfirmación de esta coincidad
                if (newpassword == confirmpassword)
                {
                    foreach (Encriptado encrip in encriptado)
                    {
                        string contradesencrit = Seguridad.DesEncriptar(encrip.Contraencript);
                        //Aqui le decimos la programa que busca en la lista hasta que el usu
                        if (encrip.Usuarioencript == label26.Text)
                        {
                            //Encriptamos la nueva contraseña
                            string nuevacontraencript = Seguridad.Encriptar(newpassword);
                            encrip.Contraencript = contradesencrit;
                            MessageBox.Show("Contraseña Actualizada con exito");
                            //Aun asi, no cambia la contraseña de la lista
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    limpiarcampos();

                }
            } //Aqui
        }

        private void limpiarcampos() //Este nos limpiara los campos y quedará listo para escribir en los textbox
        {
            txtactualpass.Clear();
            txtnewpassword.Clear();
            txtconfirmpassword.Clear();
            txtactualpass.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frmlogin login = new Frmlogin();
            login.Show();
            this.Hide();
        }
    }
}
