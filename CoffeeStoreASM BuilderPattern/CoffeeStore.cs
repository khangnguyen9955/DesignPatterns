using System;
namespace CoffeeStore{
public abstract class CoffeeStoreBuilder
{

  public abstract void OrderCoffee(string nameCoffee);
    

    protected static void GetProperties(out Sugar sugar, out HotCold hotCold, out Espresso espresso)
    {
      System.Console.WriteLine("Select amount sugar of your coffee: ");
      var sugarTypes = Enum.GetNames(typeof(Sugar)).Length;
      for (int i = 0; i < sugarTypes; i++)
      {
        Console.WriteLine(i + ". " + $"{Enum.GetName(typeof(Sugar), i)}");
        // System.Console.WriteLine(i + ". " + Enum.GetName<Sugar>(i)); 
      }
      System.Console.WriteLine("Your select (number): ");
      int sugarSelect = Convert.ToInt32(Console.ReadLine());


      System.Console.WriteLine("Select ice type of your coffee:");
      var iceTypes = Enum.GetNames(typeof(HotCold)).Length;
      for (int i = 0; i < iceTypes; i++)
      {
        Console.WriteLine(i + ". " + $"{Enum.GetName(typeof(HotCold), i)}");
      }
      System.Console.WriteLine("Your select (number): ");
      int iceSelect = Convert.ToInt32(Console.ReadLine());

      System.Console.WriteLine("Select espresso of your coffee: ");
      var espressoTypes = Enum.GetNames(typeof(Espresso)).Length;
      for (int i = 0; i < espressoTypes; i++)
      {
        System.Console.WriteLine(i + ". " + $"{Enum.GetName(typeof(Espresso), i)}");
      }

      System.Console.WriteLine("Your select (number): ");
      int espressoSelect = Convert.ToInt32(Console.ReadLine());
      sugar = (Sugar)sugarSelect;
      hotCold = (HotCold)iceSelect;
      espresso = (Espresso)espressoSelect;
    }

   

  }
}