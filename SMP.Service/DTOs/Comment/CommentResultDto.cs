using SMP.Service.DTOs.Users;
using SMP.Service.kkeDTOs;

namespace SMP.Service.DTOs.Comment;

public class CommentResultDto
{
    public PostResultDto Post { get; set; }
    public UserResultDto User { get; set; }
    public string Content { get; set; }
}
