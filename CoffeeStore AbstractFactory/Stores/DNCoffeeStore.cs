using System;
namespace CoffeeStore.Stores
{
  
  public class DNCoffeeStore  : CoffeeStore
  {
    public DNCoffeeStore(){
    }
    protected override Coffee CreateCoffee(string nameCoffee)
    {
      Sugar sugar;
      HotCold hotCold;
      Espresso espresso;
      switch (nameCoffee)
      {
        case "black":
         GetProperties(out sugar, out hotCold, out espresso);
          return new DNBlackCoffee(sugar, hotCold, espresso);
          case "milk":
         GetProperties(out sugar, out hotCold, out espresso);
        return new DNMilkCoffee(sugar, hotCold, espresso);
        case "cappuccino":
         GetProperties(out sugar, out hotCold, out espresso);
          return new DNCappuccinoCoffee(sugar, hotCold, espresso);
        default:
          return null;
      }
 
    }

     protected override Decorator CreateDecorator(){
      return new DNDecorator();
     }
  }
}