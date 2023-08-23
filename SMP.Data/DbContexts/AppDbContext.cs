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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>()
            .HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId);

        modelBuilder.Entity<Post>()
            .HasOne(x=>x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId);

        modelBuilder.Entity<Like>()
            .HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId);
        
        modelBuilder.Entity<Like>()
            .HasOne(x => x.Post)
            .WithMany()
            .HasForeignKey(x => x.PostId);

        modelBuilder.Entity<Comment>()
            .HasOne(x => x.Post)
            .WithMany()
            .HasForeignKey(x => x.PostId);
        modelBuilder.Entity<Follow>()
            .HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId);

        modelBuilder.Entity<Follow>()
        .HasOne(x => x.FallowedUser)
        .WithMany()
        .HasForeignKey(x => x.FallowedUserId);
 
        modelBuilder.Entity<Message>()
            .HasOne(x=> x.User) 
            .WithMany()
            .HasForeignKey(x=> x.UserId);

        modelBuilder.Entity<Message>()
            .HasOne(x => x.RecipientUser)
            .WithMany()
            .HasForeignKey(x => x.RecipientId);

        modelBuilder.Entity<Message>()
            .HasOne(x => x.Comment)
            .WithMany()
            .HasForeignKey(x => x.CommentId);
    }
}
