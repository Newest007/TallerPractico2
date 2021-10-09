﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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

            for (int x = 0; x < valores.Length; x++)
            {

                //Tipo de Producto
                if (valores[x] == "1.")
                {
                    producto = 0.10;
                }

                if (valores[x] == "2.")
                {
                    producto = 5.00;
                }

                if (valores[x] == "3.")
                {
                    producto = 3.00;
                }

                if (valores[x] == "4.")
                {
                    producto = 0.50;
                }

                if (valores[x] == "5.")
                {
                    producto = 0.80;
                }

                if (valores[x] == "6.")
                {
                    producto = 0.30;
                }

                if (valores[x] == "7.")
                {
                    producto = 2.25;
                }

                if (valores[x] == "8.")
                {
                    producto = 2.75;
                }

                if (valores[x] == "9.")
                {
                    producto = 1.80;
                }

                if (valores[x] == "10.")
                {
                    producto = 3.25;
                }

                //NumeroProductos
                if (valores[x] == "1")
                {
                    ventatotal = ventatotal + (producto * 1);
                }

                if (valores[x] == "2")
                {
                    ventatotal = ventatotal + (producto * 2);
                }

                if (valores[x] == "3")
                {
                    ventatotal = ventatotal + (producto * 3);
                }

                if (valores[x] == "4")
                {
                    ventatotal = ventatotal + (producto * 4);
                }

                if (valores[x] == "5")
                {
                    ventatotal = ventatotal + (producto * 5);
                }

                if (valores[x] == "6")
                {
                    ventatotal = ventatotal + (producto * 6);
                }

                if (valores[x] == "7")
                {
                    ventatotal = ventatotal + (producto * 7);
                }

                if (valores[x] == "8")
                {
                    ventatotal = ventatotal + (producto * 8);
                }

                if (valores[x] == "9")
                {
                    ventatotal = ventatotal + (producto * 9);
                }

                if (valores[x] == "10")
                {
                    ventatotal = ventatotal + (producto * 10);
                }

                if (valores[x] == "")
                {
                    MessageBox.Show("Es necesario ingresar su compra", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //label11.Text = Convert.ToString(ventatotal);

            escritor.Close();
        }
    }
}
