using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
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

        // Обработчик события на изменение выбора у SelectСomboBox и LanguageСomboBox, управляющее видимостью элементов
        private void СomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyPanel.Visible = true;
            StringKeyPanel.Visible = false;
            OutputRichTextBox.Text = "";
            KeyLabel.Text = "Неопределен.";

            if (SelectСomboBox.SelectedIndex != 0 && LanguageСomboBox.SelectedIndex != 0) EnterButton.Enabled = true;
            else EnterButton.Enabled = false;
            if (SelectСomboBox.SelectedIndex == 3)
            {
                KeyPanel.Visible = false;
                StringKeyPanel.Visible = true;
            }
        }

        // Обработчик события на нажатие кнопки "Шрифт".
        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox textBox = InputRichTextBox;

            switch (_coursor)
            {
                case Coursor.input:
                    textBox = InputRichTextBox;
                    break;
                case Coursor.output:
                    textBox = OutputRichTextBox;
                    break;
            }

            fontDialog1.Font = textBox.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = fontDialog1.Font;
            }
        }

        // Обработчик события на нажатие кнопки "Цвет".
        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox textBox = InputRichTextBox;

            switch (_coursor)
            {
                case Coursor.input:
                    textBox = InputRichTextBox;
                    break;
                case Coursor.output:
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

        // Обработчик события на нажатие кнопки "Открыть".
        private void OpenFileToolStrip_Click(object sender, EventArgs e)
        {
            string text = "";
            _filePath = "";

            try
            {
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
                MessageBox.Show("Ошибка чтения файла.\n" + exc.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            InputRichTextBox.SelectionStart = InputRichTextBox.TextLength;
        }

        // Обработчик события на нажатие кнопки "Сохранить как".
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
                        case Coursor.input:
                            Text = Encoding.UTF8.GetBytes(InputRichTextBox.Text);
                            break;
                        case Coursor.output:
                            Text = Encoding.UTF8.GetBytes(OutputRichTextBox.Text);
                            break;
                        default:
                            break;
                    }

                    fs.Write(Text, 0, Text.Length);
                }
            }


        }

        // Обработчик события на нажатие кнопки "Начать".
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

                    if (Int32.TryParse(KeyLabel.Text, out int key)) OutputRichTextBox.Text = CaesarСypher.Decoder(InputRichTextBox.Text.ToCharArray(), key, lang);
                }
            }
            catch (ArgumentException) { MessageBox.Show("Поле ввода не заполнено", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        // Метод взлома шифра.
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

        // Перечисление для хранения выбранного RichTextBox.
        private enum Coursor { input, output }
        Coursor _coursor = Coursor.input;


        // Обработчик события на выбор InputRichTextBox.
        private void InputRichTextBox_Enter(object sender, EventArgs e)
        {
            _coursor = Coursor.input;
            InputLabel.Text = "Ввод✎";
            OutputLabel.Text = "Вывод";

        }

        // Обработчик события на выбор OutputRichTextBox.
        private void OutputRichTextBox_Enter(object sender, EventArgs e)
        {
            _coursor = Coursor.output;
            OutputLabel.Text = "Вывод✎";
            InputLabel.Text = "Ввод";

        }
    }
}
