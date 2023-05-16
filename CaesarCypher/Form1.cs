using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace CaesarCypher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SelectСomboBox.SelectedIndex = 0;
            LanguageСomboBox.SelectedIndex=0;   
        }

        private void СomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectСomboBox.SelectedIndex != 0 && LanguageСomboBox.SelectedIndex != 0) EnterButton.Enabled = true;
            else EnterButton.Enabled = false;
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.ForeColor;

            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private string _filePath;

        private void OpenFileToolStrip_Click(object sender, EventArgs e)
        {
            string text = "";
            _filePath = "";

            try
            {
                openFileDialog1.FileName = _filePath;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filePath = openFileDialog1.FileName;
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(_filePath, System.Text.Encoding.UTF8))
                    {
                        text = sr.ReadToEnd();
                    }
                }
                else
                {
                    _filePath = "";
                    text = "";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка чтения файла.\n" + exc.Message, "Взлома шифра Цезаря", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            richTextBox1.Text = text;

            richTextBox1.SelectionStart = richTextBox1.TextLength;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _filePath = saveFileDialog1.FileName;
                
                
                using (FileStream fs = new FileStream(_filePath, FileMode.Create))
                {
                    byte[] Text = Encoding.UTF8.GetBytes(richTextBox1.Text);
                    fs.Write(Text, 0, Text.Length);
                }
            }


        }
    }
}
