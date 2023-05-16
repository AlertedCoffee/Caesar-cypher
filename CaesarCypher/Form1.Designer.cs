namespace CaesarCypher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectСomboBox = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.KeyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EnterButton = new System.Windows.Forms.Button();
            this.LanguageСomboBox = new System.Windows.Forms.ComboBox();
            this.KeyLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStrip,
            this.EditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStrip
            // 
            this.FileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStrip,
            this.SaveAsToolStripMenuItem});
            this.FileToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileToolStrip.Name = "FileToolStrip";
            this.FileToolStrip.Size = new System.Drawing.Size(59, 26);
            this.FileToolStrip.Text = "Файл";
            // 
            // OpenFileToolStrip
            // 
            this.OpenFileToolStrip.Name = "OpenFileToolStrip";
            this.OpenFileToolStrip.Size = new System.Drawing.Size(192, 26);
            this.OpenFileToolStrip.Text = "Открыть";
            this.OpenFileToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.OpenFileToolStrip.Click += new System.EventHandler(this.OpenFileToolStrip_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            this.SaveAsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem,
            this.ColorToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.EditToolStripMenuItem.Text = "Правка";
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.FontToolStripMenuItem.Text = "Шрифт";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.ColorToolStripMenuItem.Text = "Цвет";
            this.ColorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // SelectСomboBox
            // 
            this.SelectСomboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectСomboBox.FormattingEnabled = true;
            this.SelectСomboBox.Items.AddRange(new object[] {
            "Выбор режима работы",
            "Зашифровка",
            "Дешифровка"});
            this.SelectСomboBox.Location = new System.Drawing.Point(150, 3);
            this.SelectСomboBox.Name = "SelectСomboBox";
            this.SelectСomboBox.Size = new System.Drawing.Size(191, 26);
            this.SelectСomboBox.TabIndex = 1;
            this.SelectСomboBox.SelectedIndexChanged += new System.EventHandler(this.СomboBox_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(800, 493);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Текст...";
            // 
            // KeyNumericUpDown
            // 
            this.KeyNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyNumericUpDown.Location = new System.Drawing.Point(66, 6);
            this.KeyNumericUpDown.Name = "KeyNumericUpDown";
            this.KeyNumericUpDown.Size = new System.Drawing.Size(65, 26);
            this.KeyNumericUpDown.TabIndex = 4;
            // 
            // EnterButton
            // 
            this.EnterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterButton.Enabled = false;
            this.EnterButton.Location = new System.Drawing.Point(633, 530);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(155, 45);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Начать";
            this.EnterButton.UseVisualStyleBackColor = true;
            // 
            // LanguageСomboBox
            // 
            this.LanguageСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageСomboBox.FormattingEnabled = true;
            this.LanguageСomboBox.Items.AddRange(new object[] {
            "Выбор языка",
            "Русский",
            "Английский"});
            this.LanguageСomboBox.Location = new System.Drawing.Point(346, 3);
            this.LanguageСomboBox.Name = "LanguageСomboBox";
            this.LanguageСomboBox.Size = new System.Drawing.Size(191, 26);
            this.LanguageСomboBox.TabIndex = 6;
            this.LanguageСomboBox.SelectedIndexChanged += new System.EventHandler(this.СomboBox_SelectedIndexChanged);
            // 
            // KeyLable
            // 
            this.KeyLable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.KeyLable.AutoSize = true;
            this.KeyLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyLable.Location = new System.Drawing.Point(3, 6);
            this.KeyLable.Name = "KeyLable";
            this.KeyLable.Size = new System.Drawing.Size(52, 22);
            this.KeyLable.TabIndex = 7;
            this.KeyLable.Text = "ключ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.KeyNumericUpDown);
            this.panel1.Controls.Add(this.KeyLable);
            this.panel1.Location = new System.Drawing.Point(342, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 40);
            this.panel1.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "text";
            this.openFileDialog1.Filter = "text|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "text|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LanguageСomboBox);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.SelectСomboBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(590, 260);
            this.Name = "Form1";
            this.Text = "Взлома шифра Цезаря";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStrip;
        private System.Windows.Forms.ComboBox SelectСomboBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown KeyNumericUpDown;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.ComboBox LanguageСomboBox;
        private System.Windows.Forms.Label KeyLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

