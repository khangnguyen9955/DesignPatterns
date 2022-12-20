using System;
namespace CoffeeStore
{
  class HNCappuccinoCoffee: Coffee

  {

    public HNCappuccinoCoffee(Sugar sugar, HotCold hotCold, Espresso espresso ){
      this.name = "HN Cappuccino Coffee";
      this.sugar= sugar;
      this.hotCold= hotCold;
      this.espresso= espresso;    
      }
  }
}