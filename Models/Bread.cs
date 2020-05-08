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