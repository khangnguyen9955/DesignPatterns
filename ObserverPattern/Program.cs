using System;
using ObserverPattern.Base;
using ObserverPattern.Listeners;
namespace ObserverPattern{
  class Program
  {
   static void Main(string []args){
   var videoData = new VideoData();
   var emailListener = new EmailListener(videoData); 
   var phoneListener = new PhoneListener(videoData);
   var youtubeListener = new YoutubeListener(videoData);
   videoData.SetTitle("My first video on Youtube!");
   videoData.RemoveListener(youtubeListener);
   System.Console.WriteLine("----------------YOUTUBE CHANNEL HAS BEEN UNSUBSCRIBED---------------------");
   videoData.SetDescription("Hello guys! My first video just released!");

  System.Console.WriteLine("----------------NEW CHANNEL HAS BEEN SUBSCRIBED------------------"); 
  var FacebookListener = new FacebookListener(videoData);
  videoData.SetFileName("Very first video");
  }   
  }

}