using System;
namespace PizzaStore
{
  class DNGreekPizza : Pizza
  {
    public DNGreekPizza(){
        name = "DN Greek Pizza";
        dough = "Thin dough";
        sauce = "Chilli sauce";
        toppings.Add("Tomato");
        toppings.Add("Potato");
        
    }
  }
}