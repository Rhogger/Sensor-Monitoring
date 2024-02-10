using System.Dynamic;

class SensorLuminosity : IObserver
{
  public SensorLuminosity() { }
  private int luminosity;
  public int GetLuminosity()
  {
    return luminosity;
  }

  public void SetLuminosity(int luminosity)
  {
    this.luminosity = luminosity;
  }

  public Boolean ValidLuminosity(int luminosity)
  {
    if (luminosity < 40 || luminosity > 60) return false;
    return true;
  }

  public void Update(IObservable observable)
  {
    Console.WriteLine("Brightness should be between 40% and 60%!");
  }
}