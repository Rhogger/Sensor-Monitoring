using System.Dynamic;

class SensorHumidity : IObserver
{
  public SensorHumidity() { }
  private int humidity;
  public int GetHumidity()
  {
    return humidity;
  }
  public void SetHumidity(int humidity)
  {
    this.humidity = humidity;
  }

  public Boolean ValidHumidity(int humidity)
  {
    if (humidity < 20) return false;
    return true;
  }
  public void Update(IObservable observable)
  {
    Console.WriteLine("Humidity is too low!");
  }
}