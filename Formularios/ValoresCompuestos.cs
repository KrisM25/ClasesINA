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
    public partial class ValoresCompuestos : Form
    {
        //Arreglo con valores definidos
        string[] sexo = { "Hombre", "Mujer", "Otro" };

        //Arreglo para guardar los carritos
        string[] marcasCarro = new string[100];//con espacio para albergar 100 marcas
        int contadorMarcasAgregadas = 0;//Es para llevar el control de las marca agregadas



        public ValoresCompuestos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine(sexo[0]);//imprimimos la primer pos
            Console.WriteLine(sexo[1]);//Imprimimos la segunda pos
            sexo[0] = "Mujer";//cambiamos el valor del arreglo
            Console.WriteLine(sexo[0]);//imprimimos la primer pos
        }

        private void btnLlenarCombo_Click(object sender, EventArgs e)
        {
            cbSexo.Items.Clear();//primero quito los elementos
            cbSexo.Items.AddRange(sexo);//y después los agrego para evitar duplicidad
            cbSexo.Items.Add("Otro elemento manual");//Elemento agregado manualmente al cb
        }

        private void btnRegistrarMarca_Click(object sender, EventArgs e)
        {
            //Capturo el texto del txt
            string marcaAgregar = txtNombreMarca.Text;
            //indicamos la posicion en la que queremos guardar
            marcasCarro[contadorMarcasAgregadas] = marcaAgregar;
            //Incrementamos
            contadorMarcasAgregadas+=1;//incrementamos el contador en uno cada clic que hagamos
         
            //ahora vamos a imprimir la cantidad de elementos que tiene el vector
            lblCantidadVehiculos.Text = ""+contadorMarcasAgregadas;

            //Limpiamos el cuadro de texto en espera de otra marca
            txtNombreMarca.Text = "";
        }
    }
} 
