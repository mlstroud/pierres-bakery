using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static List<Bread> breadInventory;
    public static List<Pastry> pastryInventory;

    public static void Main()
    {
      OpenStore();
      Welcome();
      DisplayInventory();

      foreach (Bread item in breadInventory)
      {
        item.Purchase();
      }

      breadInventory[0].Purchase();
      breadInventory[0].Purchase();
      breadInventory[0].Purchase();
      Console.WriteLine("Total Cost: " + Bread.CalculatePurchaseCost());
      Console.WriteLine("Total items: " + Bread.purchasedItems.Count);
    }

    public static void GetOrder()
    {

    }

    public static void DisplayInventory()
    {
      int itemNumber = 1;
      for (int i = 0; i < breadInventory.Count; i++)
      {
        Console.WriteLine(itemNumber + ". " + breadInventory[i].Name + " - $" + breadInventory[i].Cost);
        itemNumber++;
      }
      Console.Write("\n");
      for (int i = 0; i < pastryInventory.Count; i++)
      {
        Console.WriteLine(itemNumber + ". " + pastryInventory[i].Name + " - $" + pastryInventory[i].Cost);
        itemNumber++;
      }
      Console.Write("\n");
    }

    public static void OpenStore()
    {
      breadInventory = new List<Bread>();
      pastryInventory = new List<Pastry>();
      BakeBread();
      BakePastries();
    }

    public static void BakeBread()
    {
      Bread baguette = new Bread("Baguette", 5.00);
      Bread brioche = new Bread("Brioche Ball", 5.00);
      Bread ficelle = new Bread("Ficelle", 5.00);

      breadInventory.Add(baguette);
      breadInventory.Add(brioche);
      breadInventory.Add(ficelle);
    }

    public static void BakePastries()
    {
      Pastry bearClaw = new Pastry("Bear Claw", 2.00);
      Pastry danish = new Pastry("Danishh", 2.00);
      Pastry turnover = new Pastry("Turnover", 2.00);

      pastryInventory.Add(bearClaw);
      pastryInventory.Add(danish);
      pastryInventory.Add(turnover);
    }

    public static void Welcome()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. How can we help you today?");
      Console.WriteLine("------------------------------------------------------");
    }
  }
}