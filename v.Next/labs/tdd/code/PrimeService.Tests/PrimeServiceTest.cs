using Moq;

namespace Prime.Services.Tests;

public class PrimeServiceTest
{
    [Fact]
    public void Is1PrimeTest()
    {
        var primeService = new PrimeService();
        bool result = primeService.IsPrime(1);
        Assert.False(result, "1 should not be prime");
    }
}