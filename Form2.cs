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
using MaterialSkin;
using System.Web.UI.Design.WebControls;
namespace ClasesINA
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Purple100, Primary.Purple200,
                Primary.Purple400, Accent.Purple400, TextShade.WHITE
                );

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var contrasennia = Contraseña.Text;
            var usuarioRegistrar = Usuario.Text;
            if (usuarioRegistrar.Equals(""))
            {
                MessageBox.Show("No ingresó el nombre del usuario");
            }
            else
            {
                if (contrasennia.Equals(""))
                {
                    MessageBox.Show("No ingresó la contraseña");

                }
                else
                {
                    if (!contrasennia.Equals(contrasennia/*txtRepiteContrasennia*/))
                    {
                        MessageBox.Show("XXX Las contraseñas no coinciden XXX");
                    }
                    else
                    {
                        //  Codigo para empezar a crear el usuario
                        if (Array.Exists(Login.usuario, u => u == usuarioRegistrar))
                        {
                            MessageBox.Show("Ya Existe");
                        }
                        else
                        {
                            Array.Resize(ref Login.usuario, Login.usuario.Length + 1);
                            Array.Resize(ref Login.contrasennia, Login.contrasennia.Length + 1);

                            Login.usuario[Login.usuario.Length - 1] = usuarioRegistrar;
                            Login.contrasennia[Login.contrasennia.Length - 1] = contrasennia;

                            MessageBox.Show($"Usuario: {usuarioRegistrar} creado exitosamente");
                            DialogResult respuesta = MessageBox.Show("¿Deseas autenticarte con este usuario?", "Pregunta",
                                MessageBoxButtons.OKCancel
                                );
                            switch (respuesta) {
                                case DialogResult.OK:
                                    var LoginFrm = new Login();
                                    LoginFrm.materialTextBox1.Text = usuarioRegistrar;
                                    LoginFrm.Show();
                                    this.Hide();
                                    break;

                            }
                        }
                    }
                }
            }
            var frm = new Form1();
            frm.Show();
            this.Dispose();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            var frm = new Login();
            frm.ShowDialog();
            this.Dispose();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
