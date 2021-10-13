using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ventasExpress
{
    public partial class FrmBase : Form
    {

        //Creamos la lista de la clase Usuario para almacenar todos los que ingresen
        public List<Datos> data = new List<Datos>();
        public List<Encriptado> encriptado = new List<Encriptado>(); //Aqui se guardarán los datos ya encriptados
        public FrmBase()
        {
            InitializeComponent();
            //Creamos los objetos que irán en la lista
            Datos usuario1 = new Datos { Cuenta = "admin", Contraseña = "admin123" };
            Datos usuario2 = new Datos { Cuenta = "vendedor", Contraseña = "Vendedor123" };
            Datos usuario3 = new Datos { Cuenta = "Invitado", Contraseña = "invitadoinvitado123" };

            //Añadimos los objetos a la lista
            data.Add(usuario1);
            data.Add(usuario2);
            data.Add(usuario3);

            //Ahora creamos los objetos que iran en la lista encriptada
            Encriptado encript1 = new Encriptado { Usuarioencript = usuario1.Cuenta, Contraencript = Seguridad.Encriptar(usuario1.Contraseña) };
            Encriptado encript2 = new Encriptado { Usuarioencript = usuario2.Cuenta, Contraencript = Seguridad.Encriptar(usuario2.Contraseña) };
            Encriptado encript3 = new Encriptado { Usuarioencript = usuario3.Cuenta, Contraencript = Seguridad.Encriptar(usuario3.Contraseña) };

            //Los añadimos a la lista "encriptado"
            encriptado.Add(encript1);
            encriptado.Add(encript2);
            encriptado.Add(encript3);

        }


        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmlogin login = new Frmlogin();
            login.Show();
            this.Hide();

        }

        private void FrmBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
