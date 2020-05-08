using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public static List<Bread> purchasedBread;
    public static List<Pastry> purchasedPastry;

    public Order()
    {
      purchasedItems = new List<Bread>();
      purchasedPastry = new List<Pastry>();
    }

    public static double CalculatePurchaseCost()
    {

    }

    public static double CalculateBreadTotal()
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

    public static double CalculatePastryTotal()
    {
      int totalItems = purchasedPastry.Count;
      double currentTotal = 0;
      int itemCounter = 1;

      if (totalItems > 3)
      {

      }
      else
      {

      }


      return currentTotal;
    }
  }

  public class Bread
  {
    public string Name { get; set; }
    public double Cost { get; set; }

    public Bread(string name, double cost)
    {
      Name = name;
      Cost = cost;
    }

    public void Purchase()
    {
      purchasedItems.Add(this);
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