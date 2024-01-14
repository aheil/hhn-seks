namespace Prime.Services;

public interface IPrimeService
{
  bool IsPrime(int candidate);
}

public class PrimeService : IPrimeService
{
  public bool IsPrime(int candidate)
  {
    return false;
  }
}


