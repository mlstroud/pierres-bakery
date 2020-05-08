using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string Name { get; set; }
    public double Cost { get; set; }
    private static List<Bread> _purchasedItems;

    public Bread(string name, double cost)
    {
      Name = name;
      Cost = cost;
      _purchasedItems = new List<Bread>();
    }

    public static int GetPurchasedItemsCount()
    {
      return _purchasedItems.Count;
    }

    public static List<Bread> GetPurchasedItems()
    {
      return _purchasedItems;
    }

    public void Purchase()
    {
      _purchasedItems.Add(this);
    }

    public static double CalculatePurchaseCost()
    {
      double currentTotal = 0;
      int itemCounter = 1;

      foreach (Bread item in _purchasedItems)
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
    private static List<Pastry> _purchasedItems;

    public Pastry(string name, double cost)
    {
      Name = name;
      Cost = cost;
      _purchasedItems = new List<Pastry>();
    }

    public static int GetPurchasedItemsCount()
    {
      return _purchasedItems.Count;
    }

    public static List<Pastry> GetPurchasedItems()
    {
      return _purchasedItems;
    }

    public void Purchase()
    {
      _purchasedItems.Add(this);
    }

    public static double CalculatePurchaseCost()
    {
      int totalItems = _purchasedItems.Count;
      double currentTotal = 0;

      while (totalItems > 0)
      {
        if (totalItems >= 3)
        {
          totalItems -= 3;
          currentTotal += 5;
        }
        else
        {
          totalItems--;
          currentTotal += 2;
        }
      }

      return currentTotal;
    }
  }
}