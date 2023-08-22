using SMP.Data.Commons;

namespace SMP.Data.Entities;

public class Like : Auditable
{
    public long PostId { get; set; }
    public Post Post {get; set; }
   
    public long UserId { get; set; }    
    public User User { get; set; }
}
