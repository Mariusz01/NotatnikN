namespace NotatnikN
{
    partial class OProgramieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOprogramie = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.labelWersja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOprogramie
            // 
            this.labelOprogramie.AutoSize = true;
            this.labelOprogramie.Location = new System.Drawing.Point(41, 25);
            this.labelOprogramie.Name = "labelOprogramie";
            this.labelOprogramie.Size = new System.Drawing.Size(40, 17);
            this.labelOprogramie.TabIndex = 0;
            this.labelOprogramie.Text = ",,,,,,,,";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(121, 91);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelWersja
            // 
            this.labelWersja.AutoSize = true;
            this.labelWersja.Location = new System.Drawing.Point(41, 53);
            this.labelWersja.Name = "labelWersja";
            this.labelWersja.Size = new System.Drawing.Size(36, 17);
            this.labelWersja.TabIndex = 0;
            this.labelWersja.Text = ".......";
            // 
            // OProgramieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 143);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelWersja);
            this.Controls.Add(this.labelOprogramie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OProgramieForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "O Programie";
            this.Load += new System.EventHandler(this.OProgramie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOprogramie;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labelWersja;
    }
}