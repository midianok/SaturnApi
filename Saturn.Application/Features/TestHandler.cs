using MediatR;
using Saturn.Domain.Services;

namespace Saturn.Application.Features;

public class TestHandler : IRequestHandler<TestQuery, int>
{
    private readonly ITestService  _testService;

    public TestHandler(ITestService testService)
    {
        _testService = testService;
    }

    public Task<int> Handle(TestQuery request, CancellationToken cancellationToken)
    {
        return _testService.Get(request.TestDto.Num, request.TestDto.Num2);
    }
}