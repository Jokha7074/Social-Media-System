using SMP.Data.Entities;

namespace SMP.Service.DTOs.Message;
public class MessageCreationDto
{
    public string Content { get; set; }
    public long UserId { get; set; }
    public long RecipientId { get; set; }
    public long CommentId { get; set; }
}
