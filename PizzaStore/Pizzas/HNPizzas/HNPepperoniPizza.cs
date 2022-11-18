using System;

namespace PizzaStore
{
  class HNPepperoniPizza : Pizza
  {
    public HNPepperoniPizza(){
      name="HN Pepperoni Pizza";
      dough="Thick dough";
      sauce = "Sweet sauce";
      toppings.Add("Tomato");
    }
  }
}