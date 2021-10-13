using System;
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
    public partial class FrmBase : Form
    {

        //Creamos la lista de la clase Usuario para almacenar todos los que ingresen
        public List<Datos> data = new List<Datos>();
        public List<Encriptado> encriptado = new List<Encriptado>(); //Aqui se guardarán los datos ya encriptados
        public FrmBase()
        {
            InitializeComponent();
            //Agregamos los datos a la lista "Usuarios"
            data.Add(new Datos { Cuenta = "admin", Contraseña = "admin123" });
            data.Add(new Datos { Cuenta = "vendedor", Contraseña = "Vendedor123" });
            data.Add(new Datos { Cuenta = "Invitado", Contraseña = "invitadoinvitado123" });
        }


        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }
    }
}
