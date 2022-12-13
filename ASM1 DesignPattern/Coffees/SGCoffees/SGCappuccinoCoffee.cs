using System;
namespace CoffeeStore
{
  class SGCappuccinoCoffee: Coffee

  {

    public SGCappuccinoCoffee(Sugar sugar, HotCold hotCold, Espresso espresso ){
      this.name = "SG Cappuccino Coffee";
      this.sugar= sugar;
      this.hotCold= hotCold;
      this.espresso= espresso;    
      }
  }
}