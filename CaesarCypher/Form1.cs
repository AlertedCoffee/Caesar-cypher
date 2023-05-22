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
using CaesarСypherLib;

namespace CaesarCypher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SelectСomboBox.SelectedIndex = 0;
            LanguageСomboBox.SelectedIndex = 0;
        }

        private void СomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectСomboBox.SelectedIndex != 0 && LanguageСomboBox.SelectedIndex != 0) EnterButton.Enabled = true;
            else EnterButton.Enabled = false;
        }


        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox textBox = InputRichTextBox;

            switch (_coursor)
            {
                case coursor.input:
                    textBox = InputRichTextBox;
                    break;
                case coursor.output:
                    textBox = OutputRichTextBox;
                    break;
            }

            fontDialog1.Font = textBox.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = fontDialog1.Font;
            }
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox textBox = InputRichTextBox;

            switch (_coursor)
            {
                case coursor.input:
                    textBox = InputRichTextBox;
                    break;
                case coursor.output:
                    textBox = OutputRichTextBox;
                    break;
            }

            colorDialog1.Color = textBox.ForeColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = colorDialog1.Color;
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
                    InputRichTextBox.Text = text;
                    OutputRichTextBox.Text = "";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка чтения файла.\n" + exc.Message, "Взлома шифра Цезаря", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            InputRichTextBox.SelectionStart = InputRichTextBox.TextLength;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _filePath = saveFileDialog1.FileName;


                using (FileStream fs = new FileStream(_filePath, FileMode.Create))
                {
                    byte[] Text = null;
                    switch (_coursor)
                    {
                        case coursor.input:
                            Text = Encoding.UTF8.GetBytes(InputRichTextBox.Text);
                            break;
                        case coursor.output:
                            Text = Encoding.UTF8.GetBytes(OutputRichTextBox.Text);
                            break;
                        default:
                            break;
                    }

                    fs.Write(Text, 0, Text.Length);
                }
            }


        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Language lang;
            if (LanguageСomboBox.SelectedIndex == 1)
            {
                lang = Language.russian;
            }
            else
            {
                lang = Language.english;
            }


            try
            {
                if (SelectСomboBox.SelectedIndex == 1)
                {
                    OutputRichTextBox.Text = CaesarСypher.Coder(InputRichTextBox.Text.ToCharArray(), ((int)KeyNumericUpDown.Value), lang);
                }
                else
                {
                    OutputRichTextBox.Text = CaesarСypher.Decoder(InputRichTextBox.Text.ToCharArray(), ((int)KeyNumericUpDown.Value), lang);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            InputRichTextBox.Width = TextPanel.Width / 2 - 4;
            OutputRichTextBox.Location = new Point(TextPanel.Width / 2 + 4, OutputRichTextBox.Location.Y);
            OutputRichTextBox.Width = TextPanel.Width / 2 - 4;
        }


        private enum coursor { input, output }
        coursor _coursor = coursor.input;

        private void InputRichTextBox_Enter(object sender, EventArgs e)
        {
            _coursor = coursor.input;
            OutputPen.Visible = false;
            InputPen.Visible = true;
        }

        private void OutputRichTextBox_Enter(object sender, EventArgs e)
        {
            _coursor = coursor.output;
            InputPen.Visible = false;
            OutputPen.Visible = true;
        }

    }
}
