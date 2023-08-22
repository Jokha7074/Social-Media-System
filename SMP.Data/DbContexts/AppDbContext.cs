using Microsoft.EntityFrameworkCore;
using SMP.Data.Entities;
using SMP.Domain.Entities;

namespace SMP.Data.DbContexts;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}

    public DbSet<User> Users { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Like> Likes { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Follow> Follows { get; set; }

}
