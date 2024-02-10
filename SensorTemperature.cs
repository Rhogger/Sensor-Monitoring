using System.Dynamic;

class SensorTemperature : IObserver
{
  public SensorTemperature() { }
  private int temperature;
  public int GetTemperature()
  {
    return temperature;
  }
  public void SetTemperature(int temperature)
  {
    this.temperature = temperature;
  }

  public Boolean ValidTemperature(int temperature)
  {
    if (temperature >= 32) return false;
    return true;
  }
  public void Update(IObservable observable)
  {
    Console.WriteLine("The temperature is too high!");
  }
}