using System;
using System.Windows.Forms;

namespace CaesarCypher
{
    public partial class Disclaimer : Form
    {
        public Disclaimer(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        Form1 _form1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                _form1.DisclaimerShowFlag = false;
                this.Close();
            }
            else this.Close();
        }
    }
}
