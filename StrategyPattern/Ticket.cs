using System;
namespace StrategyPattern
{
  class Ticket
  { 
    private IPromoteStrategy _promoteStrategy;
    private double _price;
    private string _name ;
   public Ticket(IPromoteStrategy promoteStrategy){
      _promoteStrategy = promoteStrategy;
   } 
   public Ticket(){

   }
   public double GetPromotedPrice(){
      return _promoteStrategy.DoDiscount(_price);
   }
    public IPromoteStrategy GetPromoteStrategy()
    {
            return _promoteStrategy;
 }
   public void SetPromoteStrategy(IPromoteStrategy promoteStrategy)
    {
      _promoteStrategy = promoteStrategy;
    }

 

    public double GetPrice(){
      return _price;
    }
    public void SetPrice(double price){
      _price = price;
    }

    public string GetName(){
      return _name;
    }
    public void SetName(string name){
      _name = name;
    }


  }
}