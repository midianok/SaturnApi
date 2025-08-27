using MediatR;
using Saturn.Application.Dtos;

namespace Saturn.Application.Features;

public class TestQuery : IRequest<int>
{
    public TestQuery(TestDto testDto)
    {
        TestDto = testDto;
    }

    public TestDto TestDto { get; set; }
}