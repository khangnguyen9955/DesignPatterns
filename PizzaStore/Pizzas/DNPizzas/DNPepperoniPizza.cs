using System;

namespace PizzaStore
{
  class DNPepperoniPizza : Pizza
  {
    public DNPepperoniPizza(){
      name="DN Pepperoni Pizza";
      dough="Thick dough";
      sauce = "Sweet sauce";
      toppings.Add("Tomato");
    }
  }
}