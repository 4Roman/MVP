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

        public event Func<string, string,string,bool> TrySignIn;
        public event Action<bool> ShowSignInResult;

        public void Show2()
        {
            this.ShowDialog();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var isSuccess = TrySignIn("Login", "Password", "7777");
            ShowSignInResult(isSuccess);
        }

    }
}
