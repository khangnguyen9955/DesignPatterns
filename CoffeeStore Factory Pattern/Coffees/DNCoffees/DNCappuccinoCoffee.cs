using System;
namespace CoffeeStore
{
  class DNCappuccinoCoffee: Coffee

  {

    public DNCappuccinoCoffee(Sugar sugar, HotCold hotCold, Espresso espresso ){
      this.name = "DN Cappuccino Coffee";
      this.sugar= sugar;
      this.hotCold= hotCold;
      this.espresso= espresso;    
      }
  }
}