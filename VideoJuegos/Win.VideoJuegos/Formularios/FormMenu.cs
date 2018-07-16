using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.VideoJuegos.Formularios;

namespace Win.VideoJuegos
{
    public partial class FormMenuPrincipal : Form
    {
        public static string NombreUsuario;
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormProducto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormCategoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var frm = new FormLogin();
            frm.ShowDialog(); 
        }

        private void consolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormConsolas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormCrearUsuario();
            frm.ShowDialog(); 
        }

        private void resetearContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormresetearContrasena();
            frm.ShowDialog(); 
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pregunta = MessageBox.Show("¿Está seguro que desa salir?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pregunta == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var pregunta = MessageBox.Show("¿Está seguro que desa salir?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pregunta == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void cerrarSesiónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var pregunta = MessageBox.Show("¿Está seguro que desa salir?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pregunta == DialogResult.Yes)
            {
                Application.Exit();
                var frm1 = new FormLogin();
                frm1.ShowDialog();                
            }
        }
    }
}
