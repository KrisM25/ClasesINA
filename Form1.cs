using ClasesINA.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesINA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comentario
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //esto es un comentario que no esta em git
        }

        private void btnConstantes_Click(object sender, EventArgs e)
        {
            //creamos una instancia del formulario Constante
            Constantes constantes = new Constantes();
            constantes.Show();//Le indicamos que se muestre
        }

        private void btnValoresCompuestos_Click(object sender, EventArgs e)
        {
            ValoresCompuestos vc = new ValoresCompuestos();
            vc.Show();
        }
    }
}
