using System;
namespace CoffeeStore
{
  class DNBlackCoffee : Coffee
  {

    public DNBlackCoffee(Sugar sugar, HotCold hotCold, Espresso espresso ){
      this.name = "DN Black Coffee";
      this.sugar= sugar;
      this.hotCold= hotCold;
      this.espresso= espresso;    
      }
  }
}