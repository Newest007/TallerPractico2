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
    public partial class Frmlogin : ventasExpress.FrmBase
    {
        //Creamos la lista de la clase Usuario para almacenar todos los que ingresen
        private List<Usuario> Usuarios = new List<Usuario>();
        private List<UsuarioEncriptado> encriptado = new List<UsuarioEncriptado>(); //Aqui se guardarán los datos ya encriptados

        private void limpiar()
        {
            txtlogincontra.Clear();
            txtloginusuario.Clear();
        }

        public Frmlogin()
        {
            InitializeComponent();
            //Agregamos los datos a la lista "Usuarios"
            Usuarios.Add(new Usuario { Cuenta = "admin", Contraseña = "admin123" });
            Usuarios.Add(new Usuario { Cuenta = "vendedor", Contraseña = "Vendedor123" });
            Usuarios.Add(new Usuario { Cuenta = "Invitado", Contraseña = "invitadoinvitado123" });

            //Procedemos a encriptar los datos a travez de un ciclo 

            foreach (Usuario a in Usuarios)
            {
                //Guardamos los datos ya encriptados en su correspondiente lista
                encriptado.Add(new UsuarioEncriptado {Usuarioencript = a.Cuenta, Contraencript = Encriptacion.Codificar(a.Contraseña)});
            }
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btncrearcuenta_Click(object sender, EventArgs e)
        {
            //Creamos un objeto para que guarde las propiedades (usuario y contraseña)
            Usuario user = new Usuario();
            //Usuario registro = new Usuario();
            
            user.Cuenta = txtloginusuario.Text;
            user.Contraseña = txtlogincontra.Text;

            for (int i = 0; i < Usuarios.Count; i++)
            {
                if (Usuarios[i].Cuenta == user.Cuenta)
                {
                    MessageBox.Show("Este usuario ya está registrado");
                }
                else
                {
                    Usuarios.Add(user);
                }
            }
            limpiar();
        }
    }
}
