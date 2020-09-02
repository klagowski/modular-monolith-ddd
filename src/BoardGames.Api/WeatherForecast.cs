using BoardGames.BuildingBlocks.Application.Requests;
using BoardGames.BuildingBlocks.Domain.Requests;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BoardGames.Api
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class TestCommand : ICommand
    {

    }

    public class TestCommandHandler : ICommandHandler<TestCommand>
    {
        public Task<Unit> Handle(TestCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
