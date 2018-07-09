using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaFormularioEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.txtEntrada.LostFocus += MiEventoDeLostFocus;
        }

        private void MiEventoDeLostFocus(object sender, EventArgs e)
        {
            var txtbox = sender as TextBox;
            txtbox.Text = txtbox.Text.ToUpper();
        }
    }
}
