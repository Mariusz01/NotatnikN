using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotatnikN
{
    public partial class OProgramieForm : System.Windows.Forms.Form
    {
        public OProgramieForm()
        {
            InitializeComponent();
        }

        private void OProgramie_Load(object sender, EventArgs e)
        {
            //wpisze dane z wpisanych w oknie Aplikacja
            labelOprogramie.Text = string.Format("Nazwa programu: {0}", Application.ProductName);
            labelWersja.Text = string.Format("wersja: {0}", Application.ProductVersion);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
