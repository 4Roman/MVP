using System;
using System.Windows.Forms;

namespace MVP
{
    public partial class Form1 : Form, IView
    {        
        public Form1()
        {
            InitializeComponent();
        }

        public event Func<string, string, bool> ViewCheckLogAndPass;
        public event Action<bool> ViewShowCheckLogAndPassResult;
        public event Func<string, bool> ViewCheckPincode;
        public event Action<bool> ViewShowCheckPincodeResult;

        bool loginAndPasswordChecked = false;



        public void Show2()
        {
            this.ShowDialog();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var pincode = textBoxPincode.Text;
            if (!loginAndPasswordChecked)
            {                
                var isSuccess = ViewCheckLogAndPass(login, password);
                ViewShowCheckLogAndPassResult(isSuccess);
                if (isSuccess)
                {
                    loginAndPasswordChecked = true;
                    textBoxPincode.Enabled = true;
                    textBoxLogin.Enabled = false;
                    textBoxPassword.Enabled = false;
                }
            }
            else 
            {
                login = textBoxLogin.Text;
                var isSuccess = ViewCheckPincode(pincode);
                ViewShowCheckPincodeResult(isSuccess);
            }
        }


    }
}
