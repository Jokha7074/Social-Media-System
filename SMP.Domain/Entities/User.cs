using SMP.Domain.Entities;
using System.Security.Cryptography.X509Certificates;

namespace SMP.Data.Entities;

public class User
{
    public long UserName { get; set; }  
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }

    ICollection<Post> Posts { get; set; }
    ICollection<Message> Messages { get; set; }
    ICollection<Follow> Followers { get; set; }
}
