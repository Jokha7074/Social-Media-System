using System.ComponentModel;

namespace SMP.Domain.Security;

public class Hasher
{
    public (string  Passwordhash, string Salt) PasswordHash(string password)
    {
        string salt = Guid.NewGuid().ToString();
        string hash = BCrypt.Net.BCrypt.HashPassword(salt+password);
        return (hash,salt);
    }
    public bool Verify(string password, string hash, string salt)
    {
        return BCrypt.Net.BCrypt.Verify(password,hash+salt);    
    }
}
