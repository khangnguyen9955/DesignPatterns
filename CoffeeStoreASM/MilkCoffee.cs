using System;
namespace CoffeeStore
{
  class MilkCoffee: Coffee
  {

    public MilkCoffee(Sugar sugar, HotCold hotCold, Espresso espresso ){
      this.name = "Milk Coffee";
      this.sugar= sugar;
      this.hotCold= hotCold;
      this.espresso= espresso;    
      }
  }
}