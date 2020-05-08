using System.Collections.Generic;

namespace Bakery.Models
{
  public class BakedItem
  {
    public string Name { get; set; }
    public int Cost { get; set; }
    public string ItemType { get; set; }
    protected static List<BakedItem> _purchasedItems = new List<BakedItem>();

    public static int GetPurchasedItemsCount()
    {
      return _purchasedItems.Count;
    }

    public static List<BakedItem> GetPurchasedItems()
    {
      return _purchasedItems;
    }

    public void Purchase()
    {
      _purchasedItems.Add(this);
    }
  }

  public class Bread : BakedItem
  {
    public Bread(string name, int cost)
    {
      Name = name;
      Cost = cost;
      ItemType = "bread";
    }

    public static int CalculatePurchaseCost()
    {
      int currentTotal = 0;
      int itemCounter = 1;

      foreach (BakedItem item in _purchasedItems)
      {
        if (item.ItemType == "bread")
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
      }

      return currentTotal;
    }
  }

  public class Pastry : BakedItem
  {
    public Pastry(string name, int cost)
    {
      Name = name;
      Cost = cost;
      ItemType = "pastry";
    }

    public static int CalculatePurchaseCost()
    {
      int totalItems = 0;
      int currentTotal = 0;

      for (int i = 0; i < _purchasedItems.Count; i++)
      {
        if (_purchasedItems[i].ItemType == "pastry")
        {
          totalItems++;
        }
      }

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