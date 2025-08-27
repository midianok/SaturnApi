using Microsoft.EntityFrameworkCore;
using Saturn.Infrastructure.Database.Configurations;
using Saturn.Infrastructure.Database.Entities;

namespace Saturn.Infrastructure.Database;

public sealed class SaturnContext : DbContext
{
    public DbSet<AiAgentEntity> AiAgents { get; set; } = null!;
    
    public DbSet<MessageEntity> Messages { get; set; } = null!;
    
    public DbSet<UserEntity> Users { get; set; } = null!;
    
    public DbSet<ChatEntity> Chats { get; set; } = null!;

    public SaturnContext(DbContextOptions<SaturnContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ChatEntityConfiguration());
        modelBuilder.ApplyConfiguration(new MessageEntityConfiguration());
        modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        modelBuilder.ApplyConfiguration(new AiAgentEntityConfiguration());
    }
}