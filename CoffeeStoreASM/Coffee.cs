  using System;
  namespace CoffeeStore
  {
    public enum Sugar{
      Less,
      Normal,
      More,
    }
    public enum HotCold{
      Hot ,
      Quarter ,

      Half ,
      HalfAndQuarter ,
      Full ,
    }
    public enum Espresso{
      One
      ,
      Two,
      Three
    }
    public abstract class Coffee
    {
      protected string name;
      protected Sugar sugar;
      protected HotCold hotCold;

      protected Espresso espresso;

      
      public void Prepare(){
          Console.WriteLine("Preparing..." + name);
      } 
      public void Grinding(){
        Console.WriteLine("Grinding..."+ name );
      }
      public void Brewing(){
        Console.WriteLine("Brewing..." + name);
      }
      public void Delivering(){
        System.Console.WriteLine("Delivering..." + name + " with " + sugar +" sugar " + " with " + hotCold + " ice " + " with " + espresso +" oz shot" );
      }
  
    }
  }