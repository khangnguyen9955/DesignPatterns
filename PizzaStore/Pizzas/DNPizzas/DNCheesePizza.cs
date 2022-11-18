using System;
namespace PizzaStore{
  class DNCheesePizza : Pizza
  {
    public DNCheesePizza(){
      name = "DN Cheese Pizza";
      dough = "Thin dough";
      sauce = "Spicy sauce";
      toppings.Add("Black olives");
      toppings.Add("Cheese");

    }
  }
}