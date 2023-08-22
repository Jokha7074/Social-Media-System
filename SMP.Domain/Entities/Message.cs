using SMP.Data.Commons;
using System.Diagnostics.Contracts;

namespace SMP.Data.Entities;

public class Message : Auditable
{
    public string Content { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }    

    public long RecipientId { get; set; }
    public User RecipientUser { get; set; }

    public long CommentId { get; set; }
    public Comment Comments { get; set; }

}
