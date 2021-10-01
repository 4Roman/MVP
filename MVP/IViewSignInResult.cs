using System;

namespace MVP
{
    public interface IViewSignInResult
    {
       //event Action<bool> ShowSignInResult;
       void Show(bool success);
    }
}