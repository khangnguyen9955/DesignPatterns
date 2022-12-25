using System;
namespace CoffeeStore.Stores
{
  public class HNCoffeeStore  : CoffeeStore
  {
    public HNCoffeeStore(){
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
          return new HNBlackCoffee(sugar, hotCold, espresso);
          case "milk":
         GetProperties(out sugar, out hotCold, out espresso);
        return new HNMilkCoffee(sugar, hotCold, espresso);
        case "cappuccino":
         GetProperties(out sugar, out hotCold, out espresso);
          return new HNCappuccinoCoffee(sugar, hotCold, espresso);
        default:
          return null;
      }
 
    }
  }
}