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
    public partial class EstructurasDeControl : Form
    {
        String[] diasSemana = { "LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES"};

     


        public EstructurasDeControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 100;
            // x>50 x entre 100 y 200 etc

            if (x > 50)
            {
                MessageBox.Show($" {x} si es mayor que 50");
            }
            else if (x > 100)
            {
                MessageBox.Show($" {x} no es mayor que 50");
            }
            else {
                if (x < 50) {
                    MessageBox.Show($" {x} < que 50");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int opcionUsuario = 5;

            switch (opcionUsuario) {
                case 1:
                    Console.WriteLine("Es uno");
                    break;
                case 2:
                    Console.WriteLine("Es dos");
                    break;
                default:
                    Console.WriteLine("No es ni uno ni dos");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"vamos por: {i}");
            }
            */
            int[] numeros = { 1, 2, 3, 4, 6, 77, 456, 345, 123 };
        
            foreach(int x in numeros) {
                Console.WriteLine($"{x}");
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"vamos por: {numeros[i]}");
            }

            String[] palabras = { "Hola", "Espero", "la", "pases", "bien" };
            foreach (string x in palabras) {
                Console.WriteLine(x);
            }

            for (int i=0; i<palabras.Length; i+=2) {
                Console.WriteLine(palabras[i]);
            }

            //también es posible hacer el siguiente ciclo
            //for (int i = 0; i < palabras.Length; Console.WriteLine(palabras[i+=2]));
        }

        private void EstructurasDeControl_Load(object sender, EventArgs e)
        {
            //VECTOR CON LOS DIAS DE LA SEMANA
            
            dtDias.Rows.Clear();//quita las filas que tiene el data

            foreach (string dia in diasSemana) {
                dtDias.Rows.Add(dia);//agregamos la fila al dt (la fila de cada iteración)
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

         
            string dia = txtDiaSemana.Text.Replace(" ","");

            if (string.IsNullOrEmpty(dia))
            {
                MessageBox.Show("Debes ingresar el día a registrar");
                txtDiaSemana.Focus();
            }
            else { 
                int pos = Array.IndexOf(diasSemana, dia);

                if (pos != -1)
                {
                    MessageBox.Show($"{dia} ya se encuentra registrado");
                }
                else { 
                    Array.Resize(ref diasSemana, diasSemana.Length+1);
                    diasSemana[diasSemana.Length-1] = dia;
                    dtDias.Rows.Clear();

                    txtDiaSemana.Text = "";
                   
                    foreach (string d in diasSemana) {
                       dtDias.Rows.Add((string)d);
                    }

                }
            }

        }

        private void dtDias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDiaSemana.Text = (string) dtDias[e.ColumnIndex, e.RowIndex].Value;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string dia = txtDiaSemana.Text;
            if (!dia.Equals("")){//En dado caso que no haya seleccionado un día para eliminarlo
                //acá abajo preguntamos si desea realmente eliminar el día seleccionado
                DialogResult opcionUsuario = MessageBox.Show(
                $"¿Deseas eliminar el día {txtDiaSemana.Text}?",
                "Advertencia!", MessageBoxButtons.YesNo);
                switch (opcionUsuario)
                {
                    case DialogResult.Yes:

                        break;
                    case DialogResult.No:
                        MessageBox.Show("Descuida, no eliminamos nada!");
                        break;
                }
            }
        }
    }
}
