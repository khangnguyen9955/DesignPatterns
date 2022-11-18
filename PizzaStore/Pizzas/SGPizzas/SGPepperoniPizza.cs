using System;

namespace PizzaStore
{
  class SGPepperoniPizza : Pizza
  {
    public SGPepperoniPizza(){
      name="SG Pepperoni Pizza";
      dough="Thick dough";
      sauce = "Sweet sauce";
      toppings.Add("Tomato");
    }
  }
}