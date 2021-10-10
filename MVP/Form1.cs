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
        public event Action LoginOrPassAreInvalid;

        bool loginAndPasswordChecked = false;

        public new void Show()
        {
            this.ShowDialog();
        }
        public void ShowInfoMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void buttonSignIn_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var pincode = textBoxPincode.Text;

            bool areLoginAndPasswordValid = (this as IView).ValidateLoginPass(login, password);
            if (!areLoginAndPasswordValid)
            {
                LoginOrPassAreInvalid();
            }
            else
            {
                bool isLoginAndPasswordChecked1 = loginAndPasswordChecked;
                if (!isLoginAndPasswordChecked1)
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
                    var isSuccess = ViewCheckPincode(pincode);
                    ViewShowCheckPincodeResult(isSuccess);
                }
            }
        }
    }
}
