using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ventasExpress
{

    public partial class Frmlogin : ventasExpress.FrmBase
    {
        

        private void limpiar()
        {
            txtlogincontra.Clear();
            txtloginusuario.Clear();
            txtloginusuario.Focus();
        }

        public Frmlogin()
        {
            InitializeComponent();
            
            

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


        public string usuario;

        

        public void btnacceder_Click(object sender, EventArgs e)
        {
            //validamos que los text box no estén vacios
            if (txtloginusuario.Text == "" || txtlogincontra.Text == "" )
            {
                MessageBox.Show("Por favor digite sus credenciales para iniciar sesión", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                foreach (Encriptado enc in encriptado)
                {
                    string desencriptado = Seguridad.DesEncriptar(enc.Contraencript);
                    if (enc.Usuarioencript == txtloginusuario.Text && desencriptado == txtlogincontra.Text)
                    {
                        //Mensaje cuando el usuario es validado 
                        MessageBox.Show("Bienvenido al programa usuario " + enc.Usuarioencript + "! ","Sea Bienvenido",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        FrmMenu menu = new FrmMenu();
                        this.Hide();
                        menu.Show();

                        usuario = enc.Usuarioencript;

                        menu.label26.Text = usuario;

                    }

                }

                //MessageBox.Show("Error, Usuario o Contraseña incorrectos", "Error de inicio de sesión");
                
                limpiar(); //Limpiamos los textbox y dejamos ya listo para escribir en el espacio para el usuario

            }
        }

        private void Frmlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
