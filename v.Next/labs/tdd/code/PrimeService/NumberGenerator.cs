namespace Prime.Services;

public class NumberGenerator
{
  IPrimeService _primeService = new PrimeService();

  public NumberGenerator(IPrimeService primeService)
  {
    _primeService = primeService;
  }
  public int GenerateNextPrime(int candidate)
  {
    while (!_primeService.IsPrime(++candidate))
    {
      //loop until we find a prime number
    };
    return candidate;
  }
}
