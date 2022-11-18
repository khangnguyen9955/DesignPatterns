using System;
namespace PizzaStore.Stores{
public abstract class PizzaStore
{
  enum pizzaType{
    Cheese,
    Greek,
    Pepperoni
  }
  public void  orderPizza(string type){
    Pizza pizza;
    pizza = CreatePizza(type);
          pizza.Prepare();
          pizza.Bake();
          pizza.Cut();
          pizza.Packaging();

  }
  protected abstract Pizza CreatePizza(string type);
 


}
}