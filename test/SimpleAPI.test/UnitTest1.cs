namespace SimpleAPI.test;
using Microsoft.Extensions.Logging;

using SimpleAPI.Controllers;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController(null);

    [Fact]
    public void GetReturnsTheWeather()
    {
        var returnVar = controller.Get();

        Assert.NotNull(returnVar);
    }

   
}