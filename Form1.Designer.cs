﻿namespace NotatnikN
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gorneMenu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.narzędziaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poleTekstowe = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKontekstowe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wytnijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gorneMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuKontekstowe.SuspendLayout();
            this.SuspendLayout();
            // 
            // gorneMenu
            // 
            this.gorneMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gorneMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.narzędziaToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.gorneMenu.Location = new System.Drawing.Point(0, 0);
            this.gorneMenu.Name = "gorneMenu";
            this.gorneMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.gorneMenu.Size = new System.Drawing.Size(600, 24);
            this.gorneMenu.TabIndex = 0;
            this.gorneMenu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // narzędziaToolStripMenuItem
            // 
            this.narzędziaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopiujToolStripMenuItem,
            this.wytnijToolStripMenuItem,
            this.wklejToolStripMenuItem,
            this.zaznaczWszystkoToolStripMenuItem});
            this.narzędziaToolStripMenuItem.Name = "narzędziaToolStripMenuItem";
            this.narzędziaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narzędziaToolStripMenuItem.Text = "Narzędzia";
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kopiujToolStripMenuItem.Text = "Kopiuj";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wklejToolStripMenuItem.Text = "Wklej";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem1,
            this.autorToolStripMenuItem});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O Programie";
            // 
            // oProgramieToolStripMenuItem1
            // 
            this.oProgramieToolStripMenuItem1.Name = "oProgramieToolStripMenuItem1";
            this.oProgramieToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.oProgramieToolStripMenuItem1.Text = "O programie";
            this.oProgramieToolStripMenuItem1.Click += new System.EventHandler(this.oProgramieToolStripMenuItem1_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // poleTekstowe
            // 
            this.poleTekstowe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poleTekstowe.Location = new System.Drawing.Point(0, 24);
            this.poleTekstowe.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.poleTekstowe.Name = "poleTekstowe";
            this.poleTekstowe.Size = new System.Drawing.Size(600, 342);
            this.poleTekstowe.TabIndex = 1;
            this.poleTekstowe.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // menuKontekstowe
            // 
            this.menuKontekstowe.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuKontekstowe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wytnijToolStripMenuItem1,
            this.kopiujToolStripMenuItem1,
            this.wklejToolStripMenuItem1,
            this.zaznaczWszystkoToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.zamknijToolStripMenuItem1});
            this.menuKontekstowe.Name = "menuKontekstowe";
            this.menuKontekstowe.Size = new System.Drawing.Size(181, 142);
            // 
            // wytnijToolStripMenuItem1
            // 
            this.wytnijToolStripMenuItem1.Name = "wytnijToolStripMenuItem1";
            this.wytnijToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.wytnijToolStripMenuItem1.Text = "Wytnij";
            this.wytnijToolStripMenuItem1.Click += new System.EventHandler(this.wytnijToolStripMenuItem1_Click);
            // 
            // kopiujToolStripMenuItem1
            // 
            this.kopiujToolStripMenuItem1.Name = "kopiujToolStripMenuItem1";
            this.kopiujToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.kopiujToolStripMenuItem1.Text = "Kopiuj";
            this.kopiujToolStripMenuItem1.Click += new System.EventHandler(this.kopiujToolStripMenuItem1_Click);
            // 
            // wklejToolStripMenuItem1
            // 
            this.wklejToolStripMenuItem1.Name = "wklejToolStripMenuItem1";
            this.wklejToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.wklejToolStripMenuItem1.Text = "Wklej";
            this.wklejToolStripMenuItem1.Click += new System.EventHandler(this.wklejToolStripMenuItem1_Click);
            // 
            // zaznaczWszystkoToolStripMenuItem1
            // 
            this.zaznaczWszystkoToolStripMenuItem1.Name = "zaznaczWszystkoToolStripMenuItem1";
            this.zaznaczWszystkoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.zaznaczWszystkoToolStripMenuItem1.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem1.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(163, 6);
            // 
            // zamknijToolStripMenuItem1
            // 
            this.zamknijToolStripMenuItem1.Name = "zamknijToolStripMenuItem1";
            this.zamknijToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.zamknijToolStripMenuItem1.Text = "Zamknij";
            this.zamknijToolStripMenuItem1.Click += new System.EventHandler(this.zamknijToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.poleTekstowe);
            this.Controls.Add(this.gorneMenu);
            this.MainMenuStrip = this.gorneMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Notatnik";
            this.gorneMenu.ResumeLayout(false);
            this.gorneMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuKontekstowe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip gorneMenu;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narzędziaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.RichTextBox poleTekstowe;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuKontekstowe;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem1;
    }
}

