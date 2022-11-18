using System;

namespace StrategyPattern{
  public class  Program {
    static void Main(string [] args){
        System.Console.WriteLine("Start getting tickets!");
        var random = new Random();
        for (int i = 1; i <= 5; i++)
        {
          var ticket = new Ticket();
          ticket.SetName("Ticket " + i);
          ticket.SetPrice(50d*i);
          GeneratePromoteStrategy(random, ticket);
          TicketDetails(ticket);
          GeneratePromoteStrategy(random, ticket);
          TicketDetails(ticket);
        }
    }
    private static void TicketDetails(Ticket ticket){
          System.Console.WriteLine(ticket.GetName());
          System.Console.WriteLine("Original price: " + ticket.GetPrice());
          System.Console.WriteLine("Apply promote " + ticket.GetPromoteStrategy().GetType().Name);
          System.Console.WriteLine("Promoted Price: " + ticket.GetPromotedPrice());


    }
    private static void GeneratePromoteStrategy(Random random, Ticket ticket){
      var strategyIndex = random.Next(0,3);
          switch(strategyIndex){
            case 0:
            ticket.SetPromoteStrategy(new NoDiscountStrategy());
            break;
            case 1: 
            ticket.SetPromoteStrategy(new QuarterDiscountStrategy());
            break;
            default:
            ticket.SetPromoteStrategy(new HalfDiscountStrategy());
            break;
          }
    }
  }
}