using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = tboxUsuario.Text;
            string clave = tboxClave.Text;

            BLL.Usuario unLogin = new BLL.Usuario();

            if(unLogin.Loguearse(usuario, clave))
            {
                MessageBox.Show("Inicio sesión correctamente");
            }
            else
            {
                MessageBox.Show("El usuario o la clave es incorrecta");
            }
        }
    }
}
