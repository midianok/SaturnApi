namespace Saturn.Domain.Services;

public interface ITestService
{
    Task<int> Get(int a, int b);
}