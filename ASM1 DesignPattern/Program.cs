using System;
using CoffeeStore.Stores;
namespace CoffeeStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var hNCoffeeStore= new HNCoffeeStore();
            hNCoffeeStore.orderCoffee("black");
            var sgCoffeeStore= new SGCoffeeStore();
            sgCoffeeStore.orderCoffee("milk");
            var dnCoffeeStore= new DNCoffeeStore();
             dnCoffeeStore.orderCoffee("cappuccino");
        }
    }
}