using System;
namespace PizzaStore.Stores
{
  public class SGPizzaStore  : PizzaStore
  {
    public SGPizzaStore(){
    }
    protected override Pizza CreatePizza(string type)
    {
            switch (type)
          {
            case "cheese":
            return new SGCheesePizza();
            case "greek":
            return new SGGreekPizza();
            case "pepperoni":
            return new SGPepperoniPizza();
            default:
            return null;
          }
    }
  }
}