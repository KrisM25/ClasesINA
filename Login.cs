using MaterialSkin.Controls;
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
    public partial class Login : MaterialForm
    {
        public static string[] usuario = { "admin" };
        public static string[] contrasennia = { "admin" };
        public Login()
        {
            InitializeComponent();
        }
    }
}
