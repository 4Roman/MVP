using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP
{
    public partial class Form1 : Form,IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event Func<string, string,bool> TrySignIn;

        public void Show2()
        {
            this.ShowDialog();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            TrySignIn("Login","Password");
        }

    }
}
