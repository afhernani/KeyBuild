using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBuild
{
    public partial class Form1 : Form
    {
        GenerarContrasenha contr;
        public Form1()
        {
            InitializeComponent();
            contr = new GenerarContrasenha();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtResultado.Text = contr.PassWord((int)numericUpDown1.Value);
        }
        private void txtLong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            aFile.SaveWithFileDialog(txtResultado.Text);
        }
    }
}
