using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : BakedItem
  {
    public Bread(string name, int cost)
    {
      Name = name;
      Cost = cost;
      ItemType = "bread";
    }

    public static List<Bread> Bake()
    {
      Bread baguette = new Bread("Baguette", 5);
      Bread brioche = new Bread("Brioche Ball", 5);
      Bread ficelle = new Bread("Ficelle", 5);

      return new List<Bread> { baguette, brioche, ficelle };
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
}