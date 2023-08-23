using System.ComponentModel;

namespace SMP.Domain.Security;

public static  class PasswordHash
{
    public static (string  Passwordhash, string Salt) Hasher(string password)
    {
        string salt = Guid.NewGuid().ToString();
        string hash = BCrypt.Net.BCrypt.HashPassword(salt+password);
        return (hash,salt);
    }

    public static bool Verify(string password, string hash, string salt)
    {
        return BCrypt.Net.BCrypt.Verify(password,hash+salt);    
    }
}
