using System;
namespace PizzaStore
{
  class SGGreekPizza : Pizza
  {
    public SGGreekPizza(){
        name = "SG Greek Pizza";
        dough = "Thin dough";
        sauce = "Chilli sauce";
        toppings.Add("Tomato");
        toppings.Add("Potato");
        
    }
  }
}