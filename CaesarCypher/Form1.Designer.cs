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
            this.KeyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EnterButton = new System.Windows.Forms.Button();
            this.LanguageСomboBox = new System.Windows.Forms.ComboBox();
            this.KeyLable = new System.Windows.Forms.Label();
            this.KeyPanel = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.InputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.InputPen = new System.Windows.Forms.PictureBox();
            this.OutputPen = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyNumericUpDown)).BeginInit();
            this.KeyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPen)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(789, 28);
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
            this.FileToolStrip.Size = new System.Drawing.Size(59, 24);
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
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
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
            this.EnterButton.Location = new System.Drawing.Point(622, 530);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(155, 45);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Начать";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
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
            // KeyPanel
            // 
            this.KeyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyPanel.Controls.Add(this.KeyNumericUpDown);
            this.KeyPanel.Controls.Add(this.KeyLable);
            this.KeyPanel.Location = new System.Drawing.Point(331, 535);
            this.KeyPanel.Name = "KeyPanel";
            this.KeyPanel.Size = new System.Drawing.Size(134, 40);
            this.KeyPanel.TabIndex = 8;
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
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.InputPen);
            this.splitContainer1.Panel1.Controls.Add(this.InputRichTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.OutputPen);
            this.splitContainer1.Panel2.Controls.Add(this.OutputRichTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(789, 476);
            this.splitContainer1.SplitterDistance = 394;
            this.splitContainer1.TabIndex = 0;
            // 
            // TextPanel
            // 
            this.TextPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPanel.Controls.Add(this.splitContainer1);
            this.TextPanel.Location = new System.Drawing.Point(0, 35);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(789, 476);
            this.TextPanel.TabIndex = 9;
            // 
            // InputRichTextBox
            // 
            this.InputRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.InputRichTextBox.Name = "InputRichTextBox";
            this.InputRichTextBox.Size = new System.Drawing.Size(394, 476);
            this.InputRichTextBox.TabIndex = 0;
            this.InputRichTextBox.Text = "";
            this.InputRichTextBox.Enter += new System.EventHandler(this.InputRichTextBox_Enter);
            // 
            // OutputRichTextBox
            // 
            this.OutputRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.OutputRichTextBox.Name = "OutputRichTextBox";
            this.OutputRichTextBox.Size = new System.Drawing.Size(391, 476);
            this.OutputRichTextBox.TabIndex = 1;
            this.OutputRichTextBox.Text = "";
            this.OutputRichTextBox.Enter += new System.EventHandler(this.OutputRichTextBox_Enter);
            // 
            // InputPen
            // 
            this.InputPen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPen.BackColor = System.Drawing.Color.Transparent;
            this.InputPen.BackgroundImage = global::CaesarCypher.Properties.Resources.icons8_карандаш_100;
            this.InputPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InputPen.Location = new System.Drawing.Point(363, 3);
            this.InputPen.Name = "InputPen";
            this.InputPen.Size = new System.Drawing.Size(28, 28);
            this.InputPen.TabIndex = 1;
            this.InputPen.TabStop = false;
            // 
            // OutputPen
            // 
            this.OutputPen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputPen.BackColor = System.Drawing.Color.Transparent;
            this.OutputPen.BackgroundImage = global::CaesarCypher.Properties.Resources.icons8_карандаш_100;
            this.OutputPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OutputPen.Location = new System.Drawing.Point(360, 3);
            this.OutputPen.Name = "OutputPen";
            this.OutputPen.Size = new System.Drawing.Size(28, 28);
            this.OutputPen.TabIndex = 2;
            this.OutputPen.TabStop = false;
            this.OutputPen.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 587);
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.KeyPanel);
            this.Controls.Add(this.LanguageСomboBox);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.SelectСomboBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(590, 260);
            this.Name = "Form1";
            this.Text = "Взлома шифра Цезаря";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyNumericUpDown)).EndInit();
            this.KeyPanel.ResumeLayout(false);
            this.KeyPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TextPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStrip;
        private System.Windows.Forms.ComboBox SelectСomboBox;
        private System.Windows.Forms.NumericUpDown KeyNumericUpDown;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.ComboBox LanguageСomboBox;
        private System.Windows.Forms.Label KeyLable;
        private System.Windows.Forms.Panel KeyPanel;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox InputRichTextBox;
        private System.Windows.Forms.RichTextBox OutputRichTextBox;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.PictureBox InputPen;
        private System.Windows.Forms.PictureBox OutputPen;
    }
}

