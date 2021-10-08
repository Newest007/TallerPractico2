﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventasExpress
{
    public partial class Frmlogin : ventasExpress.FrmBase
    {
        //Creamos la lista de la clase Usuario para almacenar todos los que ingresen
        private List<Datos> data = new List<Datos>();
        private List<Encriptado> encriptado = new List<Encriptado>(); //Aqui se guardarán los datos ya encriptados

        private void limpiar()
        {
            txtlogincontra.Clear();
            txtloginusuario.Clear();
            txtloginusuario.Focus();
        }

        public Frmlogin()
        {
            InitializeComponent();
            //Agregamos los datos a la lista "Usuarios"
            data.Add(new Datos { Cuenta = "admin", Contraseña = "admin123" });
            data.Add(new Datos { Cuenta = "vendedor", Contraseña = "Vendedor123" });
            data.Add(new Datos { Cuenta = "Invitado", Contraseña = "invitadoinvitado123" });

            //Procedemos a encriptar los datos a travez de un ciclo 

            foreach (Datos d in data)
            {
                //Guardamos los datos ya encriptados en su correspondiente lista
                encriptado.Add(new Encriptado {Usuarioencript = d.Cuenta, Contraencript = Seguridad.Encriptar(d.Contraseña)});
            }
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            //validamos que los text box no estén vacios
            if (txtloginusuario.Text == "" || txtlogincontra.Text == "" )
            {
                MessageBox.Show("Por favor digite sus credenciales para iniciar sesión", "Error");
            }
            else
            {
                foreach (Encriptado enc in encriptado)
                {
                    string desencriptado = Seguridad.DesEncriptar(enc.Contraencript);
                    if (enc.Usuarioencript == txtloginusuario.Text && desencriptado == txtlogincontra.Text)
                    {
                        //Mensaje cuando el usuario es validado 
                        MessageBox.Show("Bienvenido (" + enc.Usuarioencript + ") ");
                        FrmMenu menu = new FrmMenu();
                        this.Hide();
                        menu.Show();

                    }
                    
                }

                MessageBox.Show("Error, Usuario o Contraseña incorrectos", "Error de inicio de sesión");
                limpiar(); //Limpiamos los textbox y dejamos ya listo para escribir en el espacio para el usuario

            }
        }
    }
}
