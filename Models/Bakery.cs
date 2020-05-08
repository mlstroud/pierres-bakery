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
      int itemCounter = 1;

      foreach (Bread item in purchasedItems)
      {
        if (itemCounter <= 2)
        {
          currentTotal += item.Cost;
          itemCounter++;
        }
        else
        {
          itemCounter = 1;
        }
      }

      return currentTotal;
    }
  }

  public class Pastry
  {
    public string Name { get; set; }
    public double Cost { get; set; }
    public static List<Pastry> purchasedItems;

    public Pastry(string name, double cost)
    {
      Name = name;
      Cost = cost;
      purchasedItems = new List<Pastry>();
    }

    public void Purchase()
    {
      purchasedItems.Add(this);
    }

    public static double CalculatePurchaseCost()
    {
      int totalItems = 0;
      double currentTotal = 0;
      int itemCounter = 1;



      return currentTotal;
    }
  }
}