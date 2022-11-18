using System;
namespace PizzaStore.Stores
{
  public class DNPizzaStore  : PizzaStore
  {
    public DNPizzaStore(){
    }
    protected override Pizza CreatePizza(string type)
    {
      switch (type)
          {
            case "cheese":
            return new DNCheesePizza();
            case "greek":
            return new DNGreekPizza();
            case "pepperoni":
            return new DNPepperoniPizza();
            default:
            return null;
          }
 
    }
  }
}