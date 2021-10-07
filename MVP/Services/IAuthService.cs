namespace MVP.Services
{
    public interface IAuthService
    {
        User DbCheckLogAndPass(string login, string pass);

        User DbCheckPincode(string pincode);
    }
}
