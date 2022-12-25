using System;
namespace CoffeeStore
{
    class Program
    {
        static void Main(string[] args)
        {
           var SGCoffeeStore = new SGCoffeeStore();
           var HNCoffeeStore = new HNCoffeeStore();
           SGCoffeeStore.OrderCoffee("cappuccino");
           SGCoffeeStore.getResult();

           HNCoffeeStore.OrderCoffee("black");
           HNCoffeeStore.getResult();
        }
    }
}