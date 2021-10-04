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
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var pincode = textBoxPincode.Text;

            var isSuccess = TrySignIn(login,password,pincode);
            ShowSignInResult(isSuccess);
        }

        private void buttonSendPincode_Click(object sender, EventArgs e)
        {

        }

    }
}
