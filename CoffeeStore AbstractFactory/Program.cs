using System;
using CoffeeStore.Stores;
namespace CoffeeStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var sgCoffeeStore= new SGCoffeeStore();
            sgCoffeeStore.helper();
            sgCoffeeStore.orderCoffee("milk");
          
        }
    }
}