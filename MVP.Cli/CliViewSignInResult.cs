using System;
using System.Collections.Generic;
using System.Text;

namespace MVP.Cli
{
    public class CliViewSignInResult : IViewSignInResult
    {
        public CliViewSignInResult()
        {
        }

        //public event Action<bool> ShowSignInResult;

        public void Show(bool success)
        {
            if (success)
                Console.WriteLine("Success");
            else
                Console.WriteLine("Fail");

        }
    }
}
