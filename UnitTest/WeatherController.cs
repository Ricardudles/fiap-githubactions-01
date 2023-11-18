using FIAP_SLOT_ARM_PIPE.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace UnitTest
{
    public class WeatherController
    {
        private readonly WeatherForecastController _controller;
        private readonly Mock<ILogger<WeatherForecastController>> _logger;
        public WeatherController()
        {
            _logger = new Mock<ILogger<WeatherForecastController>>();
            _controller = new WeatherForecastController(_logger.Object);
        }
        [Fact]
        public void WheaterReturnsValue()
        {
            var test = _controller.Get();

            Assert.NotNull(test);
        }
    }
}