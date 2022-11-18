using System;
namespace ObserverPattern.Base
{
  public class EventManager
  {
    private readonly List<EventListener> _listeners = new List<EventListener>();

    public void AddListener(EventListener eventListener){
          _listeners.Add(eventListener);
    }
    public void RemoveListener(EventListener eventListener){
      _listeners.Remove(eventListener);
    }
    public void NotifyListeners(EventManager eventManager, object arg){
        _listeners.ForEach((listener)=>listener.Notify(arg));
    }
    }
}