using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MVP
{
    public class ViewSignInResultForm: IViewSignInResult
    {
        public ViewSignInResultForm()
        {
        }

        //public event Action<bool> ShowSignInResult;        
        public void Show(bool success)
        {
            if (success)
                MessageBox.Show("Success");
            else
                MessageBox.Show("Fail");
        }
    }
}
