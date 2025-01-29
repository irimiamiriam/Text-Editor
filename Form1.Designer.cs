namespace Text_Editor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textbox = new System.Windows.Forms.RichTextBox();
            this.menuStripEditor = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareCaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lipireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectareTotalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culoareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mMnMjnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aliniereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stangaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dreaptaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNewPage = new System.Windows.Forms.Button();
            this.buttonDeschide = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonCut = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.marireFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.micsorareFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(2, 158);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(1268, 657);
            this.textbox.TabIndex = 0;
            this.textbox.Text = "";
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // menuStripEditor
            // 
            this.menuStripEditor.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripEditor.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.editareToolStripMenuItem,
            this.formatareToolStripMenuItem,
            this.aliniereToolStripMenuItem});
            this.menuStripEditor.Location = new System.Drawing.Point(0, 0);
            this.menuStripEditor.Name = "menuStripEditor";
            this.menuStripEditor.Size = new System.Drawing.Size(1271, 42);
            this.menuStripEditor.TabIndex = 1;
            this.menuStripEditor.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouToolStripMenuItem,
            this.deschideToolStripMenuItem,
            this.salvareToolStripMenuItem,
            this.salvareCaToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(89, 36);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // nouToolStripMenuItem
            // 
            this.nouToolStripMenuItem.Name = "nouToolStripMenuItem";
            this.nouToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.nouToolStripMenuItem.Text = "Nou";
            this.nouToolStripMenuItem.Click += new System.EventHandler(this.nouToolStripMenuItem_Click);
            // 
            // deschideToolStripMenuItem
            // 
            this.deschideToolStripMenuItem.Name = "deschideToolStripMenuItem";
            this.deschideToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.deschideToolStripMenuItem.Text = "Deschide";
            this.deschideToolStripMenuItem.Click += new System.EventHandler(this.deschideToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // salvareCaToolStripMenuItem
            // 
            this.salvareCaToolStripMenuItem.Name = "salvareCaToolStripMenuItem";
            this.salvareCaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.salvareCaToolStripMenuItem.Text = "Salvare ca...";
            this.salvareCaToolStripMenuItem.Click += new System.EventHandler(this.salvareCaToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiereToolStripMenuItem,
            this.taiereToolStripMenuItem,
            this.lipireToolStripMenuItem,
            this.selectareTotalaToolStripMenuItem});
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.editareToolStripMenuItem.Text = "Editare";
            // 
            // copiereToolStripMenuItem
            // 
            this.copiereToolStripMenuItem.Name = "copiereToolStripMenuItem";
            this.copiereToolStripMenuItem.Size = new System.Drawing.Size(311, 44);
            this.copiereToolStripMenuItem.Text = "Copiere";
            this.copiereToolStripMenuItem.Click += new System.EventHandler(this.copiereToolStripMenuItem_Click);
            // 
            // taiereToolStripMenuItem
            // 
            this.taiereToolStripMenuItem.Name = "taiereToolStripMenuItem";
            this.taiereToolStripMenuItem.Size = new System.Drawing.Size(311, 44);
            this.taiereToolStripMenuItem.Text = "Taiere";
            this.taiereToolStripMenuItem.Click += new System.EventHandler(this.taiereToolStripMenuItem_Click);
            // 
            // lipireToolStripMenuItem
            // 
            this.lipireToolStripMenuItem.Name = "lipireToolStripMenuItem";
            this.lipireToolStripMenuItem.Size = new System.Drawing.Size(311, 44);
            this.lipireToolStripMenuItem.Text = "Lipire";
            this.lipireToolStripMenuItem.Click += new System.EventHandler(this.lipireToolStripMenuItem_Click);
            // 
            // selectareTotalaToolStripMenuItem
            // 
            this.selectareTotalaToolStripMenuItem.Name = "selectareTotalaToolStripMenuItem";
            this.selectareTotalaToolStripMenuItem.Size = new System.Drawing.Size(311, 44);
            this.selectareTotalaToolStripMenuItem.Text = "Selectare totala";
            this.selectareTotalaToolStripMenuItem.Click += new System.EventHandler(this.selectareTotalaToolStripMenuItem_Click);
            // 
            // formatareToolStripMenuItem
            // 
            this.formatareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.culoareToolStripMenuItem,
            this.marireFontToolStripMenuItem,
            this.micsorareFontToolStripMenuItem});
            this.formatareToolStripMenuItem.Name = "formatareToolStripMenuItem";
            this.formatareToolStripMenuItem.Size = new System.Drawing.Size(142, 38);
            this.formatareToolStripMenuItem.Text = "Formatare";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // culoareToolStripMenuItem
            // 
            this.culoareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMnMjnToolStripMenuItem});
            this.culoareToolStripMenuItem.Name = "culoareToolStripMenuItem";
            this.culoareToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.culoareToolStripMenuItem.Text = "Culoare";
            // 
            // mMnMjnToolStripMenuItem
            // 
            this.mMnMjnToolStripMenuItem.Name = "mMnMjnToolStripMenuItem";
            this.mMnMjnToolStripMenuItem.Size = new System.Drawing.Size(279, 44);
            this.mMnMjnToolStripMenuItem.Text = " m  mn mjn ";
            // 
            // aliniereToolStripMenuItem
            // 
            this.aliniereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stangaToolStripMenuItem,
            this.centruToolStripMenuItem,
            this.dreaptaToolStripMenuItem});
            this.aliniereToolStripMenuItem.Name = "aliniereToolStripMenuItem";
            this.aliniereToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.aliniereToolStripMenuItem.Text = "Aliniere";
            // 
            // stangaToolStripMenuItem
            // 
            this.stangaToolStripMenuItem.Name = "stangaToolStripMenuItem";
            this.stangaToolStripMenuItem.Size = new System.Drawing.Size(231, 44);
            this.stangaToolStripMenuItem.Text = "Stanga ";
            this.stangaToolStripMenuItem.Click += new System.EventHandler(this.stangaToolStripMenuItem_Click);
            // 
            // centruToolStripMenuItem
            // 
            this.centruToolStripMenuItem.Name = "centruToolStripMenuItem";
            this.centruToolStripMenuItem.Size = new System.Drawing.Size(231, 44);
            this.centruToolStripMenuItem.Text = "Centru";
            this.centruToolStripMenuItem.Click += new System.EventHandler(this.centruToolStripMenuItem_Click);
            // 
            // dreaptaToolStripMenuItem
            // 
            this.dreaptaToolStripMenuItem.Name = "dreaptaToolStripMenuItem";
            this.dreaptaToolStripMenuItem.Size = new System.Drawing.Size(231, 44);
            this.dreaptaToolStripMenuItem.Text = "Dreapta";
            this.dreaptaToolStripMenuItem.Click += new System.EventHandler(this.dreaptaToolStripMenuItem_Click);
            // 
            // buttonNewPage
            // 
            this.buttonNewPage.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNewPage.BackgroundImage")));
            this.buttonNewPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNewPage.Location = new System.Drawing.Point(2, 97);
            this.buttonNewPage.Name = "buttonNewPage";
            this.buttonNewPage.Size = new System.Drawing.Size(67, 55);
            this.buttonNewPage.TabIndex = 2;
            this.buttonNewPage.Text = " ";
            this.buttonNewPage.UseVisualStyleBackColor = false;
            this.buttonNewPage.Click += new System.EventHandler(this.buttonNewPage_Click);
            // 
            // buttonDeschide
            // 
            this.buttonDeschide.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeschide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeschide.BackgroundImage")));
            this.buttonDeschide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeschide.Location = new System.Drawing.Point(75, 97);
            this.buttonDeschide.Name = "buttonDeschide";
            this.buttonDeschide.Size = new System.Drawing.Size(67, 55);
            this.buttonDeschide.TabIndex = 3;
            this.buttonDeschide.Text = " ";
            this.buttonDeschide.UseVisualStyleBackColor = false;
            this.buttonDeschide.Click += new System.EventHandler(this.buttonDeschide_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.Location = new System.Drawing.Point(148, 97);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(67, 55);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = " ";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Transparent;
            this.buttonCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCopy.BackgroundImage")));
            this.buttonCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCopy.Location = new System.Drawing.Point(252, 97);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(67, 55);
            this.buttonCopy.TabIndex = 5;
            this.buttonCopy.Text = " ";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonCut
            // 
            this.buttonCut.BackColor = System.Drawing.Color.Transparent;
            this.buttonCut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCut.BackgroundImage")));
            this.buttonCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCut.Location = new System.Drawing.Point(325, 97);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(67, 55);
            this.buttonCut.TabIndex = 6;
            this.buttonCut.Text = " ";
            this.buttonCut.UseVisualStyleBackColor = false;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.BackColor = System.Drawing.Color.Transparent;
            this.buttonPaste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPaste.BackgroundImage")));
            this.buttonPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPaste.Location = new System.Drawing.Point(398, 97);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(67, 55);
            this.buttonPaste.TabIndex = 7;
            this.buttonPaste.Text = " ";
            this.buttonPaste.UseVisualStyleBackColor = false;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // marireFontToolStripMenuItem
            // 
            this.marireFontToolStripMenuItem.Name = "marireFontToolStripMenuItem";
            this.marireFontToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.marireFontToolStripMenuItem.Text = "Marire font";
            this.marireFontToolStripMenuItem.Click += new System.EventHandler(this.marireFontToolStripMenuItem_Click);
            // 
            // micsorareFontToolStripMenuItem
            // 
            this.micsorareFontToolStripMenuItem.Name = "micsorareFontToolStripMenuItem";
            this.micsorareFontToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.micsorareFontToolStripMenuItem.Text = "Micsorare font";
            this.micsorareFontToolStripMenuItem.Click += new System.EventHandler(this.micsorareFontToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 811);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.buttonCut);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDeschide);
            this.Controls.Add(this.buttonNewPage);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.menuStripEditor);
            this.MainMenuStrip = this.menuStripEditor;
            this.Name = "Form1";
            this.Text = "Text editor v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripEditor.ResumeLayout(false);
            this.menuStripEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textbox;
        private System.Windows.Forms.MenuStrip menuStripEditor;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareCaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lipireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectareTotalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem culoareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aliniereToolStripMenuItem;
        private System.Windows.Forms.Button buttonNewPage;
        private System.Windows.Forms.Button buttonDeschide;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.ToolStripMenuItem stangaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dreaptaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mMnMjnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marireFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem micsorareFontToolStripMenuItem;
    }
}

