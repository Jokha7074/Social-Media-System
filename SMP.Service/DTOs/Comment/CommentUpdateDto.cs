namespace SMP.Service.DTOs.Comment;

public class CommentUpdateDto
{
    public long Id { get; set; }
    public long PostId { get; set; }
    public long UserId { get; set; }
    public string Content { get; set; }
}
