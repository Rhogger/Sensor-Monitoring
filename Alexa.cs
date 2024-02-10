public class Alexa : IObservable
{
  public Alexa() { }

  List<IObserver> observers = new List<IObserver>();

  public void Notify()
  {
    foreach (var ob in observers)
    {
      ob.Update(this);
    }
  }

  public void Register(IObserver observer)
  {
    this.observers.Add(observer);
  }

  public void Remove(IObserver observer)
  {
    this.observers.Remove(observer);
  }

  public void ToWarn()
  {
    this.Notify();
  }
}