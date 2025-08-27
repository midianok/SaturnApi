using Saturn.Infrastructure.Database.Entities;

namespace Saturn.Infrastructure.Database.Repositories.Abstractions;

public interface IChatCachedRepository
{
    Task<ChatEntity> GetAsync(long chatId);
}