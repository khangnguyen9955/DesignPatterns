using System;
namespace CoffeeStore
{
  class DNMilkCoffee: Coffee
  {

    public DNMilkCoffee(Sugar sugar, HotCold hotCold, Espresso espresso ){
      this.name = "DN Milk Coffee";
      this.sugar= sugar;
      this.hotCold= hotCold;
      this.espresso= espresso;    
      }
  }
}