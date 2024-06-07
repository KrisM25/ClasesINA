using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ClasesINA
{
    public partial class Principal : MaterialForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var name = materialTextBox1.Text;
            int unit = materialSlider1.Value;
            Double price = Double.Parse(materialTextBox2.Text);
            Double total = Double.Parse((materialTextBox3.Text));
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
