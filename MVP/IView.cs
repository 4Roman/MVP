using System;
using System.Collections.Generic;
using System.Text;

namespace MVP
{
    public interface IView
    {
        event Func<string,string,bool> TrySignIn;
        void Show2();
    }
}