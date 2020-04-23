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
    public partial class Form1 : System.Windows.Forms.Form
    {
        #region Czesci
            string sciezka = "";
        #endregion Czesci

        #region Poczatek
        public Form1()
        {
            InitializeComponent();
        }
        #endregion Poczatek

        #region Plik
        private void NowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sciezka = string.Empty;
            poleTekstowe.Clear();
        }
        private void OtwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Plik tekstowy (TXT)|*.txt"
            };
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sciezka = dialog.FileName;
                poleTekstowe.Text = File.ReadAllText(sciezka);
            }
        }

        private async void ZapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sciezka))
            {
                using(SaveFileDialog sfd = new SaveFileDialog() { Filter="Text Documents|*.txt", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(sfd.FileName))
                            {
                                await sw.WriteLineAsync(poleTekstowe.Text);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sciezka))
                    {
                        await sw.WriteLineAsync(poleTekstowe.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void ZapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            await sw.WriteLineAsync(poleTekstowe.Text);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ZamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void OProgramieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using(OProgramieForm nowa= new OProgramieForm())
            {
                nowa.ShowDialog();
            }
        }

        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OAutorzeForm nowa2 = new OAutorzeForm())
            {
                nowa2.ShowDialog();
            }
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
