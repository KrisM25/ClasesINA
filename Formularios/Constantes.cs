using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesINA.Formularios
{
    public partial class Constantes : Form
    {
        //VALORES CONSTANTES
        const double PI = 3.14;


        public Constantes()
        {
            InitializeComponent();
        }

        private void btnImprimirConstante_Click(object sender, EventArgs e)
        {
            lblValorConstante.Text = "" + PI;
        }
    }
}
