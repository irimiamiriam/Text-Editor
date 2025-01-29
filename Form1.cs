using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class Form1 : Form
    {
        bool notSaved = true;
        string currentFile = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            copiereToolStripMenuItem.PerformClick();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(FontFamily fontFamily in System.Drawing.FontFamily.Families)
            {
                fontToolStripMenuItem.DropDownItems.Add(fontFamily.Name);
            }
            foreach(KnownColor knowColor in Enum.GetValues(typeof(KnownColor)))
            {
                culoareToolStripMenuItem.DropDownItems.Add(knowColor.ToString());
             
            }
            foreach(ToolStripDropDownItem item in culoareToolStripMenuItem.DropDownItems)
            {
                item.Click += colorToolStripMenuItem_Click;
            }
            foreach (ToolStripDropDownItem item in fontToolStripMenuItem.DropDownItems)
            {
                item.Click += fontToolStripMenuItem_Click;
            }
        }

       

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedToolItem = sender as ToolStripDropDownItem;
            Color color = Color.FromName(selectedToolItem.Text);
             textbox.SelectionColor = color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedToolItem = sender as ToolStripDropDownItem;
            FontFamily fontFamily = new FontFamily(selectedToolItem.Text);
            textbox.SelectionFont = new Font(fontFamily, textbox.SelectionFont.Size);
        }

        private void copiereToolStripMenuItem_Click(object sender, EventArgs e)
        {   
           
            Clipboard.SetText(textbox.SelectedText);
        }

        private void taiereToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(textbox.SelectedText);
            textbox.SelectedText = "";
        }

        private void lipireToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var curent = textbox.SelectionStart;
           string pastedText = Clipboard.GetText();
           textbox.Text = textbox.Text.Insert(textbox.SelectionStart, pastedText);
           textbox.SelectionStart = curent;
        }

        private void selectareTotalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.SelectAll();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            taiereToolStripMenuItem.PerformClick();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            lipireToolStripMenuItem.PerformClick();
        }

        private void stangaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void dreaptaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.SelectionAlignment = HorizontalAlignment.Right;
           
        }

        private void nouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notSaved)
            {   MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult dialogResult =  MessageBox.Show("Fisierul nu e salvat! Doriti sa salvati inainte de a crea un fisier nou?", "Atentie", buttons);
                if(dialogResult == DialogResult.Yes)
                {
                    salvareToolStripMenuItem.PerformClick();
                    textbox.Text = "";
                    notSaved= false;
                    currentFile = null;
                }else
                {
                    textbox.Text = "";
                    currentFile = null;
                }
                
            }else
            {
                textbox.Text = "";
                currentFile = null;
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFile == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textbox.SaveFile(saveFileDialog.FileName);
                    currentFile= saveFileDialog.FileName;
                    notSaved = false;
                }
            }
            else
            {
                
                File.WriteAllText(currentFile, textbox.Rtf);
               notSaved = false;
            }
        }

        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = openFileDialog.FileName;
                textbox.LoadFile(currentFile);
                notSaved = false;
            }
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            notSaved = true;
        }

        private void buttonNewPage_Click(object sender, EventArgs e)
        {
            nouToolStripMenuItem.PerformClick();

        }

        private void buttonDeschide_Click(object sender, EventArgs e)
        {
            deschideToolStripMenuItem.PerformClick();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            salvareToolStripMenuItem.PerformClick();    
        }

        private void salvareCaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textbox.SaveFile(saveFileDialog.FileName);
                currentFile = saveFileDialog.FileName;
                notSaved = false ;
            }

        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notSaved)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult dialogResult = MessageBox.Show("Fisierul nu e salvat! Doriti sa salvati inainte de a crea un fisier nou?", "Atentie", buttons);
                if (dialogResult == DialogResult.Yes)
                {
                    salvareToolStripMenuItem.PerformClick();
                   Application.Exit();
                   
                }
                else
                {
                   Application.Exit();
                }

            }
            else
            {
                textbox.Text = "";
                currentFile = null;
            }
        }

        private void marireFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.SelectionFont = new Font(textbox.SelectionFont.FontFamily, textbox.SelectionFont.Size+2);
        }

        private void micsorareFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.SelectionFont = new Font(textbox.SelectionFont.FontFamily, textbox.SelectionFont.Size - 2);
        }
    }
}
