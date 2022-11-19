using System;
namespace SingletonPattern
{
  public class Database
  {
    // private static Database database = new Database(); // by this way, database will always be initialized when the program run
    // now implement this pattern with lazy loading
    // we only create Database instance when we need it
    // with lazy loading, we need to take care about multithreading
    private static readonly object lockThread = new object();

    // testing 
    private int index;
    private static volatile Database database; // volatile keyword used for get latest version of this variable
    private Database(int index){
      this.index = index;
    }

    public static Database GetDatabase(){
      if(database == null){
        lock (lockThread) // with "lock" we can lock other threads 
        {
          // now if the first thread is done, the other threads will go here and check again whether first thread initialized the database
          // if yes so return, else => create 
        if(database== null){
          var rand = new Random();
            database = new Database(rand.Next(0,4));
        }
        }
      }
      return database;
    }

    public void SelectQuery(){
      System.Console.WriteLine("Query select in Database " + this.index );
    }

    public void WhereQuery(){
      System.Console.WriteLine("Query where in database " + this.index);
    }

    
  }
}