using System;
namespace PizzaStore{
  class HNCheesePizza : Pizza
  {
    public HNCheesePizza(){
      name = "HN Cheese Pizza";
      dough = "Thin dough";
      sauce = "Spicy sauce";
      toppings.Add("Black olives");
      toppings.Add("Cheese");

    }
  }
}