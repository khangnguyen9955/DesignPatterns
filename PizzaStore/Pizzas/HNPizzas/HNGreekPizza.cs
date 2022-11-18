using System;
namespace PizzaStore
{
  class HNGreekPizza : Pizza
  {
    public HNGreekPizza(){
        name = "HN Greek Pizza";
        dough = "Thin dough";
        sauce = "Chilli sauce";
        toppings.Add("Tomato");
        toppings.Add("Potato");
        
    }
  }
}