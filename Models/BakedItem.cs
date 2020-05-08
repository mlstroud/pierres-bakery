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
}