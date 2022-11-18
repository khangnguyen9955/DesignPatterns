using System;
using ObserverPattern.Base;
using ObserverPattern.Listeners;
namespace ObserverPattern.Listeners{
  public class FacebookListener : EventListener
  {
    public FacebookListener(EventManager eventManager){
      this.eventManager = eventManager;
      this.eventManager.AddListener(this);
    }
    public override void Notify(object arg)
    {
        if (eventManager is VideoData videoData){
        System.Console.WriteLine("Notify all listeners via FACEBOOK with new data" + 
        "\n\tTitle:{0}" +
         "\n\tDescription:{1}" +
          "\n\tFile Name:{2}", videoData.GetTitle(), videoData.GetDescription(), videoData.GetFileName()
        );
      }
    }
  }
}