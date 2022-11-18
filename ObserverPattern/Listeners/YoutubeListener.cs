using System;
using ObserverPattern.Base;
namespace ObserverPattern.Listeners{
  public class YoutubeListener : EventListener
  { 
    public YoutubeListener(EventManager eventManager){
      this.eventManager = eventManager;
      this.eventManager.AddListener(this);
    }
    public override void Notify( object arg)
    {
      if (eventManager is VideoData videoData){
        System.Console.WriteLine("Notify all listeners via Youtube with new data" + 
        "\n\tTitle:{0}" +
         "\n\tDescription:{1}" +
          "\n\tFile Name:{2}", videoData.GetTitle(), videoData.GetDescription(), videoData.GetFileName()
        );
      }
    }
  }
}