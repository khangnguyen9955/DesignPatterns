using System;
namespace CoffeeStore.Stores
{
  public class SGCoffeeStore  : CoffeeStore
  {
    public SGCoffeeStore(){
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
          return new SGBlackCoffee(sugar, hotCold, espresso);
          case "milk":
         GetProperties(out sugar, out hotCold, out espresso);
        return new SGMilkCoffee(sugar, hotCold, espresso);
        case "cappuccino":
         GetProperties(out sugar, out hotCold, out espresso);
          return new SGCappuccinoCoffee(sugar, hotCold, espresso);
        default:
          return null;
      }
 
    }

      protected override Decorator CreateDecorator(){
      return new SGDecorator();
     }
  }
}