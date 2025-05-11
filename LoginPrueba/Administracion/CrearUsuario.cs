using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPrueba.Administracion
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            BE.Usuario usuario = new BE.Usuario();
            usuario.Apellido = tboxApellido.Text;
            usuario.Nombre = tboxNombre.Text;
            usuario.DNI = Convert.ToInt32(nudDNI.Value);
            usuario.Email = tboxEmail.Text;
            usuario.Perfil = BE.Usuario.PerfilUsuario.Administrador;
            usuario.UserName = tboxUserName.Text;
            usuario.Clave = tboxClave.Text;


            BLL.Usuario logicaUsuario = new BLL.Usuario();

            if (logicaUsuario.CrearUsuario(usuario))
            {
                MessageBox.Show("Se ha creado el usuario exitosamente!!!");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un problema, intente más tarde");
            }

            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarUsuarios_Click(object sender, EventArgs e)
        {
            frmConsultaUsuarios formulario = new frmConsultaUsuarios();
            formulario.ShowDialog();
        }
    }
}
