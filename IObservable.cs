public interface IObservable
{
  public void Register(IObserver observer);
  public void Remove(IObserver observer);
  public void Notify();
}