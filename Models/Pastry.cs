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