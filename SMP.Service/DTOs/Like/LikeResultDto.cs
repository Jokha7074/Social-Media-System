using SMP.Service.DTOs.Users;
using SMP.Service.kkeDTOs;

namespace SMP.Service.DTOs.Like;

public class LikeResultDto
{
    public long Id { get; set; }
    public PostResultDto Post { get; set; }
    public UserResultDto User { get; set; }
}
