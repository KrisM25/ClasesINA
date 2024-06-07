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
        string[] names = new string[1];
        int[] units = new int[1];
        double[] prices = new double[1];
        double[] totals = new double[1];

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var name = materialTextBox1.Text;
            int unit = materialSlider1.Value;
            Double price = Double.Parse(materialTextBox2.Text);
            Double total = Double.Parse((materialTextBox3.Text));

            if (total <= 0 || unit <= 0 || price <= 0)
            {
                MessageBox.Show("No");
            }
            else
            {
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("No Name");
                }
                else 
                {
                    Array.Resize(ref names, names.Length + 1);
                    Array.Resize(ref units, units.Length + 1);
                    Array.Resize(ref prices, prices.Length + 1);
                    Array.Resize(ref totals, totals.Length + 1);
                    names[names.Length - 1] = name;
                    units[units.Length - 1] = unit;
                    prices[prices.Length - 1] = price;
                    totals[totals.Length - 1] = total;

                    MessageBox.Show("Sí");
                    dataGridView1.Rows.Add(new object[] { name, unit, price, total });

                }
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_Leave(object sender, EventArgs e)
        {
            int unit = materialSlider1.Value;
            Double price = Double.Parse(materialTextBox2.Text);
           materialTextBox3.Text = (price * unit).ToString();
        }

        private void materialSlider1_onValueChanged(object sender, int newValue)
        {
            int unit = materialSlider1.Value;
            Double price = Double.Parse(materialTextBox2.Text);
            materialTextBox3.Text = (price * unit).ToString();
        }
    }
}
