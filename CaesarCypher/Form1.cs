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
            KeyPanel.Visible = true;
            StringKeyPanel.Visible = false;
            OutputRichTextBox.Text = "";

            if (SelectСomboBox.SelectedIndex != 0 && LanguageСomboBox.SelectedIndex != 0) EnterButton.Enabled = true;
            else EnterButton.Enabled = false;
            if (SelectСomboBox.SelectedIndex == 3)
            {
                KeyPanel.Visible = false;
                StringKeyPanel.Visible = true;
            }
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
            OutputRichTextBox.Text = "";

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
                else if (SelectСomboBox.SelectedIndex == 2)
                {
                    OutputRichTextBox.Text = CaesarСypher.Decoder(InputRichTextBox.Text.ToCharArray(), ((int)KeyNumericUpDown.Value), lang);
                }
                else if (SelectСomboBox.SelectedIndex == 3)
                {
                    KeyLabel.Text = Hack(InputRichTextBox.Text, lang);
                    int key = 0;
                    
                    if(Int32.TryParse(KeyLabel.Text, out key)) OutputRichTextBox.Text = CaesarСypher.Decoder(InputRichTextBox.Text.ToCharArray(), key, lang);
                }
                else if (SelectСomboBox.SelectedIndex == 4)
                {
                    int key = CaesarСypher.FindKey(InputRichTextBox.Text);
                    KeyLabel.Text = key.ToString();
                    OutputRichTextBox.Text =  CaesarСypher.Decoder(InputRichTextBox.Text.ToCharArray(), key, Language.english);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string Hack(string text, Language lang)
        {
            string key = "Неопределен.";

            try
            {
                key = CaesarСypher.HackCypher(InputRichTextBox.Text, lang).ToString();
                return key;
            }
            catch (CaesarСypher.NotEnoughSymbolsException ex)
            {
                DialogResult dialog;

                dialog = MessageBox.Show(ex.Message + "\nВы желаете продолжить?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    key = CaesarСypher.HackCypher(InputRichTextBox.Text, lang, true).ToString();
                    return key;
                }
                else return key;
            }
        }

        private enum coursor { input, output }
        coursor _coursor = coursor.input;

        private void InputRichTextBox_Enter(object sender, EventArgs e)
        {
            _coursor = coursor.input;
            InputLabel.Text = "Ввод✎";
            OutputLabel.Text = "Вывод";

        }

        private void OutputRichTextBox_Enter(object sender, EventArgs e)
        {
            _coursor = coursor.output;
            OutputLabel.Text = "Вывод✎";
            InputLabel.Text = "Ввод";

        }
    }
}
