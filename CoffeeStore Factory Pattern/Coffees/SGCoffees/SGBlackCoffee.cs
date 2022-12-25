using System;
namespace CoffeeStore
{
  class SGBlackCoffee : Coffee
  {

    public SGBlackCoffee(Sugar sugar, HotCold hotCold, Espresso espresso ){
      this.name = "SG Black Coffee";
      this.sugar= sugar;
      this.hotCold= hotCold;
      this.espresso= espresso;    
      }
  }
}