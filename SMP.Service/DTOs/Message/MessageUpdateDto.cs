using SMP.Service.DTOs.Comment;
using SMP.Service.DTOs.Users;

namespace SMP.Service.DTOs.Message;

public class MessageUpdateDto
{
    public long Id { get; set; }
    public string Content { get; set; }
    public UserResultDto User { get; set; }
    public UserResultDto RecipientUser { get; set; }
    public CommentResultDto Comment { get; set; }
}