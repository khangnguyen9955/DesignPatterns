using System;
namespace CoffeeStore
{
  class CappuccinoCoffee: Coffee
  {

    public CappuccinoCoffee(Sugar sugar, HotCold hotCold, Espresso espresso ){
      this.name = "Cappuccino Coffee";
      this.sugar= sugar;
      this.hotCold= hotCold;
      this.espresso= espresso;    
      }
  }
}