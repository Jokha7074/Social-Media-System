using SMP.Data.Enums;
using SMP.Service.DTOs.Users;

namespace SMP.Service.kkeDTOs;

public class PostResultDto
{
    public long UserId { get; set; }
    public UserCreateDto User { get; set; }

    public Content Content { get; set; }
}
