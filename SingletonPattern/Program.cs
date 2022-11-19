using System;
namespace SingletonPattern{
  class Program
  {
    static void Main (string[] args){
      var thread1= new Thread(()=> Database.GetDatabase().SelectQuery());
      var thread2= new Thread(()=> Database.GetDatabase().WhereQuery());
      var thread3= new Thread(()=> Database.GetDatabase().SelectQuery());
      thread1.Start();
            thread2.Start();
                  thread3.Start();
    }
  }
}