using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApps
{
    public partial class LoginTextBox : UserControl
    {
        public LoginTextBox()
        {
            InitializeComponent();
        }

        public string _label = "default value";
        public bool _isPassword = false;

        public string label
        {
            get { return _label; }
            set { _label = value; }
        }

        public bool isPassword
        {
            get { return _isPassword; }
            set { _isPassword = value; }
        }

        private void loginTextbox_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = label;

            if(isPassword)
            {
                textBox1.UseSystemPasswordChar = true;
            }
            else
            {
                textBox1.UseSystemPasswordChar = false;
            }
        }
    }
}
