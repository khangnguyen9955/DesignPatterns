using System;
namespace CoffeeStore
{
    class Program
    {
        static void Main(string[] args)
        {
           var coffeeStore = new CoffeeStore();

           coffeeStore.OrderCoffee("cappuccino");
           coffeeStore.OrderCoffee("latte");
        }
    }
}