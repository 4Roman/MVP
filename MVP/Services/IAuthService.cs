namespace MVP.Services
{
    public interface IAuthService
    {
        User TryAuth(string login, string pass, string pincode);
    }
}