using System;
namespace PizzaStore.Stores
{
  public class HNPizzaStore  : PizzaStore
  {
    public HNPizzaStore(){
    }
    protected override Pizza CreatePizza(string type)
    {
          switch (type)
          {
            case "cheese":
            return new HNCheesePizza();
            case "greek":
            return new HNGreekPizza();
            case "pepperoni":
            return new HNPepperoniPizza();
            default:
            return null;
          }
    }
  }
}