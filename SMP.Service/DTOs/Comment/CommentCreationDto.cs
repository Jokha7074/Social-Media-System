using SMP.Data.Entities;

namespace SMP.Service.DTOs.Comment;

public class CommentCreationDto
{
    public long PostId { get; set; }
    public long UserId { get; set; }
    public string Content { get; set; }
}
