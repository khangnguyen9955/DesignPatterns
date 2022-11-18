using System;
namespace ObserverPattern.Base
{
  public abstract class EventListener
  {
    protected EventManager eventManager;
    public abstract void Notify( object arg);
  }
}