using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotatnikN
{
    public partial class Form1 : Form
    {
        #region Czesci
            string sciezka = "";
        #endregion Czesci

        #region Konstruktor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion Konstruktor

        
        #region Plik

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Plik tekstowy (TXT)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sciezka = dialog.FileName;
                poleTekstowe.Text = File.ReadAllText(sciezka);
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion Plik

        #region Narzedzia
        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion Narzedzia

        #region Oprogramie
        private void oProgramieToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion Oprogramie

        #region KontekstowePlik
        private void wytnijToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void kopiujToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void wklejToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void zaznaczWszystkoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void zamknijToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        #endregion KontekstowePlik
    }
}
