﻿namespace SMP.Service.DTOs.Users;

public class UserResultDto
{
    public long Id { get; set; }
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }
}


