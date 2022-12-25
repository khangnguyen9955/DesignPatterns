using System;
namespace CoffeeStore
{
  class SGMilkCoffee: Coffee
  {

    public SGMilkCoffee(Sugar sugar, HotCold hotCold, Espresso espresso ){
      this.name = "SG Milk Coffee";
      this.sugar= sugar;
      this.hotCold= hotCold;
      this.espresso= espresso;    
      }
  }
}