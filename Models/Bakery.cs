using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string Name { get; set; }
    public int Cost { get; set; }
    private static List<Bread> _purchasedItems = new List<Bread>();

    public Bread(string name, int cost)
    {
      Name = name;
      Cost = cost;
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

    public static int CalculatePurchaseCost()
    {
      int currentTotal = 0;
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
    public int Cost { get; set; }
    private static List<Pastry> _purchasedItems = new List<Pastry>();

    public Pastry(string name, int cost)
    {
      Name = name;
      Cost = cost;
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

    public static int CalculatePurchaseCost()
    {
      int totalItems = _purchasedItems.Count;
      int currentTotal = 0;

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