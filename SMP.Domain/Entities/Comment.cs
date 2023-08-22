using SMP.Data.Commons;
using SMP.Data.Enums;

namespace SMP.Data.Entities;

public class Comment : Auditable
{
    public long PostId { get; set; }
    public Post Post { get; set; }

    public long UserId {get; set; }
    public User User { get; set; }

    public string Content { get; set; }
}
