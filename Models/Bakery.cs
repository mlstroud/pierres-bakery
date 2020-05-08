using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string Name { get; set; }
    public double Cost { get; set; }
    public static List<Bread> purchasedItems;

    public Bread(string name, double cost)
    {
      Name = name;
      Cost = cost;
      purchasedItems = new List<Bread>();
    }

    public void Purchase()
    {
      purchasedItems.Add(this);
    }

    public static double CalculatePurchaseCost()
    {
      int totalItems = 0;
      double currentTotal = 0;

      foreach (Bread item in purchasedItems)
      {
        totalItems++;
        if (totalItems % 2 == 1)
        {
          currentTotal += item.Cost;
        }
      }

      return currentTotal;
    }
  }

  public class Pastry
  {
    public string Name { get; set; }
    public double Cost { get; set; }

    public Pastry(string name, double cost)
    {
      Name = name;
      Cost = cost;
    }
  }
}