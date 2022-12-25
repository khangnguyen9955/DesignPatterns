using System;
namespace CoffeeStore
{
  class HNMilkCoffee: Coffee
  {

    public HNMilkCoffee(Sugar sugar, HotCold hotCold, Espresso espresso ){
      this.name = "HN Milk Coffee";
      this.sugar= sugar;
      this.hotCold= hotCold;
      this.espresso= espresso;    
      }
  }
}