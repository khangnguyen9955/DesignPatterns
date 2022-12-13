using System;
namespace CoffeeStore
{
  class HNBlackCoffee : Coffee
  {

    public HNBlackCoffee(Sugar sugar, HotCold hotCold, Espresso espresso ){
      this.name = "HN Black Coffee";
      this.sugar= sugar;
      this.hotCold= hotCold;
      this.espresso= espresso;    
      }
  }
}