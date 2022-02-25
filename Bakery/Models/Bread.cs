using System.Collections.Generic;
namespace Bakery.Models
{
  public class Bread
  {
    public string Description { get; }
    private static List<Bread>_instances = new List<Bread> {};

    public static List<Bread> GetAll()
    {
      return _instances;
    }
    
  }
}