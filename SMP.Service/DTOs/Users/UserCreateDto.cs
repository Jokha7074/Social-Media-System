namespace SMP.Service.DTOs.Users;

public class UserCreateDto
{
    public long UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }
}

