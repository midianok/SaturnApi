using Saturn.Domain.Services;

namespace Saturn.Infrastructure.Services;

public class TestService : ITestService
{
    public Task<int> Get()
    {
        return Task.FromResult(42);
    }

    public Task<int> Get(int a, int b)
    {
        return Task.FromResult(a + b);
    }
}