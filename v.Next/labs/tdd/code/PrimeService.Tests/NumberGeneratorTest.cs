using Moq;

namespace Prime.Services.Tests;

public class NumberGeneratorTest
{
  [Fact]
  public void GenerateNextPrimeTest()
  {
    var primeServiceMock = new Mock<IPrimeService>();
    primeServiceMock.Setup(x => x.IsPrime(10)).Returns(false);
    primeServiceMock.Setup(x => x.IsPrime(11)).Returns(true);
    var numberGenerator = new NumberGenerator(primeServiceMock.Object);
    int result = numberGenerator.GenerateNextPrime(9);
    Assert.Equal(11, result);
  }
}