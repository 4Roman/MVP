using System;


public class User
{
    public User(string login, string password, string pincode)
    {
        this.login = login ?? throw new ArgumentNullException(nameof(login));
        this.password = password ?? throw new ArgumentNullException(nameof(password));
        this.pincode = pincode ?? throw new ArgumentNullException(nameof(pincode));
        this.record = int.MaxValue;
    }

    public string login { get; set; }
    public string password { get; set; }
    public string pincode { get; set; }
    public int record { get; set; }

    public static string CreatePincode()
    {
        Random rnd = new Random();
        int value = rnd.Next(0, 9999);
        string pincode = value.ToString();
        return pincode;
    }
    
}

