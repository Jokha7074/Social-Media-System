using SMP.Data.Commons;
using SMP.Data.Entities;

namespace SMP.Domain.Entities;

public class Follow : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }

    public long FallowedUserId { get; set; }
    public User FallowedUser { get; set; }  
}
