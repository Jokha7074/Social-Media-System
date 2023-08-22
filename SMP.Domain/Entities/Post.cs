using SMP.Data.Commons;
using SMP.Data.Enums;

namespace SMP.Data.Entities;

public class Post : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }

    public Content Content { get; set; }

    ICollection<Like> likes { get; set; }
    ICollection<Comment> comments { get; set; }
}
