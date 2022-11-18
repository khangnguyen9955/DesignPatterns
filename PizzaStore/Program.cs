using System;
using PizzaStore.Stores;
namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var hnPizzaStore = new HNPizzaStore();
            hnPizzaStore.orderPizza("greek");
            var sgPizzaStore = new SGPizzaStore();
            sgPizzaStore.orderPizza("pepperoni");
            var dnPizzaStore = new DNPizzaStore();
             dnPizzaStore.orderPizza("cheese");
        }
    }
}