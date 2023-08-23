using SMP.Data.Enums;

namespace SMP.Service.kkeDTOs;

public class PostUpdateDto
{
    public long UserId { get; set; }
    public Content Content { get; set; }
}