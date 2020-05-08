using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry : BakedItem
  {
    public Pastry(string name, int cost)
    {
      Name = name;
      Cost = cost;
      ItemType = "pastry";
    }

    public static List<Pastry> Bake()
    {
      Pastry bearClaw = new Pastry("Bear Claw", 2);
      Pastry danish = new Pastry("Danishh", 2);
      Pastry turnover = new Pastry("Turnover", 2);

      return new List<Pastry> { bearClaw, danish, turnover };
    }

    public static int CalculatePurchaseCost()
    {
      int totalItems = 0;
      int currentTotal = 0;

      foreach (BakedItem item in _purchasedItems)
      {
        if (item.ItemType == "pastry")
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