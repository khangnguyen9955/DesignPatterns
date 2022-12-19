using System;
namespace CoffeeStore
{
  class BlackCoffee : Coffee
  {

    public BlackCoffee(Sugar sugar, HotCold hotCold, Espresso espresso ){
      this.name = "Black Coffee";
      this.sugar= sugar;
      this.hotCold= hotCold;
      this.espresso= espresso;    
      }
  }
}