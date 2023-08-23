using SMP.Data.Entities;

namespace SMP.Service.DTOs.Like;

public class LikeCreationDto
{
    public long PostId { get; set; }
    public long UserId { get; set; }
}
