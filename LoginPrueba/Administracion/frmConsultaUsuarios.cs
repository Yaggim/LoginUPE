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
    public partial class frmConsultaUsuarios : Form
    {
        public frmConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

            BLL.Usuario usuarioDeNegocio = new BLL.Usuario();

            dgvUsuarios.DataSource = usuarioDeNegocio.ListarUsuarios();

            cboxUsuarios.DataSource = usuarioDeNegocio.ListarUsuarios();

        }


        private void frmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            BLL.Usuario usuarioDeNegocio = new BLL.Usuario();
            cboxUsuarios.DisplayMember = "UserName";
            cboxUsuarios.ValueMember = "UserName";
            //cboxUsuarios.DataSource = usuarioDeNegocio.ListarUsuarios();

            dgvUsuarios.DataSource = usuarioDeNegocio.ListarUsuarios();
        }

        private void btnMostrarValorDelCombo_Click(object sender, EventArgs e)
        {
            if (cboxUsuarios.Items.Count>0)
            {
                MessageBox.Show(cboxUsuarios.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("No hay ningún elemento en el combobox");
            }
        }

        private void btnMostrarDatosDelClienteDelComboBox_Click(object sender, EventArgs e)
        {
            if (cboxUsuarios.Items.Count>0 && cboxUsuarios.SelectedValue.ToString() != string.Empty)
            {
                BE.Usuario objUsuarioDelCombo = (BE.Usuario)cboxUsuarios.SelectedItem;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("UserName del usuario: " + objUsuarioDelCombo.UserName);
                sb.AppendLine("DNI del usuario: " + objUsuarioDelCombo.DNI.ToString());
                sb.AppendLine("Nombre del usuario: " + objUsuarioDelCombo.Nombre);
                sb.AppendLine("Apellido del usuario: " + objUsuarioDelCombo.Nombre);

                MessageBox.Show(sb.ToString());
            }
            else
            {
                MessageBox.Show("No hay nada seleccionado");
            }
        }
    }
}
