using Saturn.Infrastructure.Database.Entities;

namespace Saturn.Infrastructure.Database.Repositories.Abstractions;

public interface IMessageRepository
{
    Task<List<MessageEntity>> GetMessageChainAsync(long chatId, long messageId);
}