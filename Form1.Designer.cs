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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gorneMenu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narzędziaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKontekstowe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wytnijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poleTekstowe = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dymek = new System.Windows.Forms.ToolTip(this.components);
            this.gorneMenu.SuspendLayout();
            this.menuKontekstowe.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.gorneMenu.TabIndex = 1;
            this.gorneMenu.Text = "menuStrip1";
            this.gorneMenu.MouseEnter += new System.EventHandler(this.gorneMenu_MouseEnter);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            this.plikToolStripMenuItem.ToolTipText = "Plik";
            this.plikToolStripMenuItem.MouseEnter += new System.EventHandler(this.plikToolStripMenuItem_MouseEnter);
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.ToolTipText = "Nowy dokument";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.NowyToolStripMenuItem_Click);
            this.nowyToolStripMenuItem.MouseEnter += new System.EventHandler(this.nowyToolStripMenuItem_MouseEnter);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.ToolTipText = "Otwórz nowy dokument";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.OtwórzToolStripMenuItem_Click);
            this.otwórzToolStripMenuItem.MouseEnter += new System.EventHandler(this.otwórzToolStripMenuItem_MouseEnter);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.ToolTipText = "Zapisz dokument";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.ZapiszToolStripMenuItem_Click);
            this.zapiszToolStripMenuItem.MouseEnter += new System.EventHandler(this.zapiszToolStripMenuItem_MouseEnter);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            this.zapiszJakoToolStripMenuItem.ToolTipText = "Zapisz jako ...";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.ZapiszJakoToolStripMenuItem_Click);
            this.zapiszJakoToolStripMenuItem.MouseEnter += new System.EventHandler(this.zapiszJakoToolStripMenuItem_MouseEnter);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.ToolTipText = "Zamknij program";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.ZamknijToolStripMenuItem_Click);
            this.zamknijToolStripMenuItem.MouseEnter += new System.EventHandler(this.zamknijToolStripMenuItem_MouseEnter);
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
            this.narzędziaToolStripMenuItem.ToolTipText = "Narzędzia";
            this.narzędziaToolStripMenuItem.MouseEnter += new System.EventHandler(this.narzędziaToolStripMenuItem_MouseEnter);
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.kopiujToolStripMenuItem.Text = "Kopiuj";
            this.kopiujToolStripMenuItem.ToolTipText = "Kopiuj tekst";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.KopiujToolStripMenuItem_Click);
            this.kopiujToolStripMenuItem.MouseEnter += new System.EventHandler(this.kopiujToolStripMenuItem_MouseEnter);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            this.wytnijToolStripMenuItem.ToolTipText = "Wytnij tekst";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.WytnijToolStripMenuItem_Click);
            this.wytnijToolStripMenuItem.MouseEnter += new System.EventHandler(this.wytnijToolStripMenuItem_MouseEnter);
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.wklejToolStripMenuItem.Text = "Wklej";
            this.wklejToolStripMenuItem.ToolTipText = "Wklej tekst";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.WklejToolStripMenuItem_Click);
            this.wklejToolStripMenuItem.MouseEnter += new System.EventHandler(this.wklejToolStripMenuItem_MouseEnter);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.ToolTipText = "Zaznacz cały tekst";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.ZaznaczWszystkoToolStripMenuItem_Click);
            this.zaznaczWszystkoToolStripMenuItem.MouseEnter += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_MouseEnter);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem1,
            this.autorToolStripMenuItem});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O Programie";
            this.oProgramieToolStripMenuItem.ToolTipText = "Informacje";
            this.oProgramieToolStripMenuItem.MouseEnter += new System.EventHandler(this.oProgramieToolStripMenuItem_MouseEnter);
            // 
            // oProgramieToolStripMenuItem1
            // 
            this.oProgramieToolStripMenuItem1.Name = "oProgramieToolStripMenuItem1";
            this.oProgramieToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.oProgramieToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.oProgramieToolStripMenuItem1.Text = "O programie";
            this.oProgramieToolStripMenuItem1.ToolTipText = "Info o programie";
            this.oProgramieToolStripMenuItem1.Click += new System.EventHandler(this.OProgramieToolStripMenuItem1_Click);
            this.oProgramieToolStripMenuItem1.MouseEnter += new System.EventHandler(this.oProgramieToolStripMenuItem1_MouseEnter);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.ToolTipText = "Info o autorze programu";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.AutorToolStripMenuItem_Click);
            this.autorToolStripMenuItem.MouseEnter += new System.EventHandler(this.autorToolStripMenuItem_MouseEnter);
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
            this.menuKontekstowe.Size = new System.Drawing.Size(167, 120);
            // 
            // wytnijToolStripMenuItem1
            // 
            this.wytnijToolStripMenuItem1.Name = "wytnijToolStripMenuItem1";
            this.wytnijToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.wytnijToolStripMenuItem1.Text = "Wytnij";
            this.wytnijToolStripMenuItem1.Click += new System.EventHandler(this.WytnijToolStripMenuItem1_Click);
            // 
            // kopiujToolStripMenuItem1
            // 
            this.kopiujToolStripMenuItem1.Name = "kopiujToolStripMenuItem1";
            this.kopiujToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.kopiujToolStripMenuItem1.Text = "Kopiuj";
            this.kopiujToolStripMenuItem1.Click += new System.EventHandler(this.KopiujToolStripMenuItem1_Click);
            // 
            // wklejToolStripMenuItem1
            // 
            this.wklejToolStripMenuItem1.Name = "wklejToolStripMenuItem1";
            this.wklejToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.wklejToolStripMenuItem1.Text = "Wklej";
            this.wklejToolStripMenuItem1.Click += new System.EventHandler(this.WklejToolStripMenuItem1_Click);
            // 
            // zaznaczWszystkoToolStripMenuItem1
            // 
            this.zaznaczWszystkoToolStripMenuItem1.Name = "zaznaczWszystkoToolStripMenuItem1";
            this.zaznaczWszystkoToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
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
            this.zamknijToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.zamknijToolStripMenuItem1.Text = "Zamknij";
            this.zamknijToolStripMenuItem1.Click += new System.EventHandler(this.ZamknijToolStripMenuItem1_Click);
            // 
            // poleTekstowe
            // 
            this.poleTekstowe.ContextMenuStrip = this.menuKontekstowe;
            this.poleTekstowe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poleTekstowe.Location = new System.Drawing.Point(3, 23);
            this.poleTekstowe.Name = "poleTekstowe";
            this.poleTekstowe.Size = new System.Drawing.Size(594, 320);
            this.poleTekstowe.TabIndex = 2;
            this.poleTekstowe.Text = "";
            this.poleTekstowe.MouseEnter += new System.EventHandler(this.poleTekstowe_MouseEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.poleTekstowe, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 1, 1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(600, 20);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.MouseEnter += new System.EventHandler(this.statusStrip1_MouseEnter);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(19, 15);
            this.toolStripStatusLabel1.Text = "    ";
            this.toolStripStatusLabel1.MouseEnter += new System.EventHandler(this.toolStripStatusLabel1_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.gorneMenu);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.gorneMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notatnik";
            this.gorneMenu.ResumeLayout(false);
            this.gorneMenu.PerformLayout();
            this.menuKontekstowe.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.RichTextBox poleTekstowe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip dymek;
    }
}

