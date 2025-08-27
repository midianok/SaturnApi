using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Saturn.Infrastructure.Database.Entities;

namespace Saturn.Infrastructure.Database.Configurations;

public class ChatEntityConfiguration : IEntityTypeConfiguration<ChatEntity>
{
    public void Configure(EntityTypeBuilder<ChatEntity> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.HasOne(x => x.AiAgent)
            .WithMany(x => x.Chats)
            .HasForeignKey(x => x.AiAgentId);
    }
}