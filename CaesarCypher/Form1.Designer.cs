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
            this.Label2 = new System.Windows.Forms.Label();
            this.KeyPanel = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.InputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.StringKeyPanel = new System.Windows.Forms.Panel();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyNumericUpDown)).BeginInit();
            this.KeyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.StringKeyPanel.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(789, 30);
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
            "Дешифровка",
            "Взлом"});
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
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label2.Location = new System.Drawing.Point(3, 6);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 22);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "ключ";
            // 
            // KeyPanel
            // 
            this.KeyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyPanel.Controls.Add(this.KeyNumericUpDown);
            this.KeyPanel.Controls.Add(this.Label2);
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
            this.splitContainer1.Panel1.Controls.Add(this.InputRichTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.OutputRichTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(789, 450);
            this.splitContainer1.SplitterDistance = 394;
            this.splitContainer1.TabIndex = 0;
            // 
            // InputRichTextBox
            // 
            this.InputRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.InputRichTextBox.Name = "InputRichTextBox";
            this.InputRichTextBox.Size = new System.Drawing.Size(394, 450);
            this.InputRichTextBox.TabIndex = 0;
            this.InputRichTextBox.Text = "";
            this.InputRichTextBox.Enter += new System.EventHandler(this.InputRichTextBox_Enter);
            // 
            // OutputRichTextBox
            // 
            this.OutputRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OutputRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.OutputRichTextBox.Name = "OutputRichTextBox";
            this.OutputRichTextBox.ReadOnly = true;
            this.OutputRichTextBox.Size = new System.Drawing.Size(391, 450);
            this.OutputRichTextBox.TabIndex = 1;
            this.OutputRichTextBox.Text = "";
            this.OutputRichTextBox.Enter += new System.EventHandler(this.OutputRichTextBox_Enter);
            // 
            // TextPanel
            // 
            this.TextPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPanel.Controls.Add(this.splitContainer1);
            this.TextPanel.Location = new System.Drawing.Point(0, 61);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(789, 450);
            this.TextPanel.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Location = new System.Drawing.Point(0, 31);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.InputLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.OutputLabel);
            this.splitContainer2.Size = new System.Drawing.Size(789, 27);
            this.splitContainer2.SplitterDistance = 394;
            this.splitContainer2.TabIndex = 10;
            // 
            // InputLabel
            // 
            this.InputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLabel.Location = new System.Drawing.Point(0, 0);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(394, 27);
            this.InputLabel.TabIndex = 2;
            this.InputLabel.Text = "Ввод✎";
            this.InputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputLabel
            // 
            this.OutputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.Location = new System.Drawing.Point(0, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(391, 27);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Вывод";
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StringKeyPanel
            // 
            this.StringKeyPanel.Controls.Add(this.KeyLabel);
            this.StringKeyPanel.Controls.Add(this.Label1);
            this.StringKeyPanel.Location = new System.Drawing.Point(298, 530);
            this.StringKeyPanel.Name = "StringKeyPanel";
            this.StringKeyPanel.Size = new System.Drawing.Size(203, 54);
            this.StringKeyPanel.TabIndex = 11;
            this.StringKeyPanel.Visible = false;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyLabel.Location = new System.Drawing.Point(70, 13);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(128, 24);
            this.KeyLabel.TabIndex = 1;
            this.KeyLabel.Text = "Неопределен.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1.Location = new System.Drawing.Point(3, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Ключ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 587);
            this.Controls.Add(this.StringKeyPanel);
            this.Controls.Add(this.splitContainer2);
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.StringKeyPanel.ResumeLayout(false);
            this.StringKeyPanel.PerformLayout();
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
        private System.Windows.Forms.Label Label2;
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Panel StringKeyPanel;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label Label1;
    }
}

