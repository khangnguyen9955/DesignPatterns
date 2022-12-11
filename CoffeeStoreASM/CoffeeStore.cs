using System;
namespace CoffeeStore{
public class CoffeeStore
{

  public void OrderCoffee(string nameCoffee){
    Coffee coffee;
    System.Console.WriteLine("Select amount sugar of your coffee: ");
    var sugarTypes= Enum.GetNames(typeof(Sugar)).Length;
    for (int i = 0; i <sugarTypes; i++)
    {
       Console.WriteLine(i +". " + $"{Enum.GetName(typeof(Sugar), i)}");  
      // System.Console.WriteLine(i + ". " + Enum.GetName<Sugar>(i)); 
    }
    System.Console.WriteLine("Your select (number): ");
    int sugarSelect =  Convert.ToInt32(Console.ReadLine());


    System.Console.WriteLine("Select ice type of your coffee:");
    var iceTypes= Enum.GetNames(typeof(HotCold)).Length;
    for (int i = 0; i <iceTypes; i++)
    {
       Console.WriteLine(i +". " + $"{Enum.GetName(typeof(HotCold), i)}");  
    }
   System.Console.WriteLine("Your select (number): ");
    int iceSelect=  Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Select espresso of your coffee: ");
    var espressoTypes= Enum.GetNames(typeof(Espresso)).Length;
    for (int i = 0; i <espressoTypes; i++)
    {
      System.Console.WriteLine(i + ". " + $"{Enum.GetName(typeof(Espresso), i)}"); 
    }
 
        System.Console.WriteLine("Your select (number): ");
    int espressoSelect =  Convert.ToInt32(Console.ReadLine());
    Sugar sugar = (Sugar)sugarSelect;
    HotCold hotCold= (HotCold)iceSelect;
    Espresso  espresso= (Espresso)espressoSelect;

    switch(nameCoffee)
    {
      case "black":
      coffee  = new BlackCoffee(sugar,hotCold,espresso);
      break;
      // case "milk":
      // coffee = new MilkCoffee();
      // break;
      default:
      System.Console.WriteLine("We do not have " + nameCoffee+ " coffee");
      return;
    }
    coffee.Prepare();
    coffee.Grinding();
    coffee.Brewing();
    coffee.Delivering();

  }
 
//  protected override Pizza CreatePizza(string type)
//     {
//       switch (type)
//           {
//             case "cheese":
//             return new DNCheesePizza();
//             case "greek":
//             return new DNGreekPizza();
//             case "pepperoni":
//             return new DNPepperoniPizza();
//             default:
//             return null;
//           }
 
//     }

}
}