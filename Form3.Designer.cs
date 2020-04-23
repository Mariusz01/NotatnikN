namespace NotatnikN
{
    partial class OAutorzeForm
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
            this.btn2OK = new System.Windows.Forms.Button();
            this.labelAutor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn2OK
            // 
            this.btn2OK.Location = new System.Drawing.Point(44, 68);
            this.btn2OK.Name = "btn2OK";
            this.btn2OK.Size = new System.Drawing.Size(75, 23);
            this.btn2OK.TabIndex = 0;
            this.btn2OK.Text = "&OK";
            this.btn2OK.UseVisualStyleBackColor = true;
            this.btn2OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(41, 26);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(19, 13);
            this.labelAutor.TabIndex = 1;
            this.labelAutor.Text = "Mariusz Moskwa";
            // 
            // OAutorzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 116);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.btn2OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OAutorzeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2OK;
        private System.Windows.Forms.Label labelAutor;
    }
}