using System;
namespace PizzaStore{
  class SGCheesePizza : Pizza
  {
    public SGCheesePizza(){
      name = "SG Cheese Pizza";
      dough = "Thin dough";
      sauce = "Spicy sauce";
      toppings.Add("Black olives");
      toppings.Add("Cheese");

    }
  }
}