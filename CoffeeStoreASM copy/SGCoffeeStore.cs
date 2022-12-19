namespace CoffeeStore
{
  public class SGCoffeeStore : CoffeeStoreBuilder
  { 
 
    public override void OrderCoffee(string nameCoffee)
    {
       Coffee coffee;
      Sugar sugar;
      HotCold hotCold;
      Espresso espresso; 
      switch (nameCoffee)
      {
        case "black":
         GetProperties(out sugar, out hotCold, out espresso);
          coffee = new BlackCoffee(sugar, hotCold, espresso);
          break;
        case "milk":
         GetProperties(out sugar, out hotCold, out espresso);
          coffee = new MilkCoffee(sugar, hotCold, espresso);
          break;
        case "cappuccino":
         GetProperties(out sugar, out hotCold, out espresso);
          coffee = new CappuccinoCoffee(sugar, hotCold, espresso);
          break;
        default:
          System.Console.WriteLine("We do not have " + nameCoffee + " coffee");
          return;
      }
      coffee.Prepare();
      coffee.Grinding();
      coffee.Brewing();
      coffee.Delivering();

    }

    public void getResult(){
      System.Console.WriteLine("Return the coffee information");
    }
  }


}