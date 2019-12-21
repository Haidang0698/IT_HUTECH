using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        public List<int> listSize = new List<int>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
        public Form1()
        {
            InitializeComponent();
            //Create ComboBox Font
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                tSCBFont.Items.Add(font.Name);
            }
            //Create ConboBox Size
            foreach (int i in listSize)
            {
                tSCBSize.Items.Add(i);
            }
            //Create default font & size
            tSCBFont.Text = "Tahoma";
            tSCBSize.Text = "14";
            richText.Font = new Font(tSCBFont.Text, float.Parse(tSCBSize.Text));
        }
        //EVENT FOR BUTTON FORMAT
        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }
        //CHECK AND PERFORMANCE FUNCTION
        private void tSCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tSCBFont.Text != "" && tSCBSize.Text != "")
            {
                richText.SelectionFont = new Font(tSCBFont.Text, float.Parse(tSCBSize.Text));
            }
        }
        //FUNCTION NEW FILE
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Remove content from richtext
            richText.Text = "";
            tSCBFont.Text = "Tahoma";
            tSCBSize.Text = "14";
            richText.Font = new Font(tSCBFont.Text, float.Parse(tSCBSize.Text));
        }
        //FUNCTION OPEN FILE
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RTF Files (*.rtf)|*.rtf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richText.LoadFile(openFileDialog.FileName);
            }
        }
        //FUNCTION SAVE FILE
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "RTF files (*.rtf)|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                richText.SaveFile(saveFileDialog.FileName);
            }          
        }
        //FUNCTION EXIT FILE
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You may want to exit ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Have you saved ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                this.Close();
            }
        }
        //EVENT FOR BUTTON BOLD
        private void btnB_Click(object sender, EventArgs e)
        {
            if(richText.SelectionFont == null)
                return;
            FontStyle style = richText.SelectionFont.Style;
            if (richText.SelectionFont.Bold)
                style &= ~FontStyle.Bold;
            else
                style |= FontStyle.Bold;
            richText.SelectionFont = new Font(richText.SelectionFont, style);
        }
        //EVENT FOR BUTTON ITALYC
        private void btnI_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont == null)
                return;
            FontStyle style = richText.SelectionFont.Style;
            if (richText.SelectionFont.Italic)
                style &= ~FontStyle.Italic;
            else
                style |= FontStyle.Italic;
            richText.SelectionFont = new Font(richText.SelectionFont, style);
        }
        //EVENT FOR BUTTON UNDERLINE
        private void btnU_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont == null)
                return;
            FontStyle style = richText.SelectionFont.Style;
            if (richText.SelectionFont.Underline)
                style &= ~FontStyle.Underline;
            else
                style |= FontStyle.Underline;
            richText.SelectionFont = new Font(richText.SelectionFont, style);
        }
    }
}
