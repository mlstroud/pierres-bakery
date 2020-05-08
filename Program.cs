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
      PromptCustomer();
    }

    public static void PromptCustomer()
    {
      bool finished = false;
      string userInput;

      while (!finished)
      {
        DisplayInventory();
        if (BakedItem.GetPurchasedItemsCount() > 0)
        {
          Console.WriteLine("You currently have " + BakedItem.GetPurchasedItemsCount() + " items in your cart.");
        }
        Console.WriteLine("Enter an item # to purchase it, or type done to finish.");
        userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int orderItem))
        {
          Console.Clear();
          if (orderItem < 1 || orderItem > (breadInventory.Count + pastryInventory.Count))
          {
            Console.WriteLine("Sorry, that wasn't a valid option.");
          }
          else if (orderItem > breadInventory.Count)
          {
            pastryInventory[(orderItem - breadInventory.Count) - 1].Purchase();
          }
          else
          {
            breadInventory[orderItem - 1].Purchase();
          }
        }
        else
        {
          if (userInput.ToLower() == "done")
          {
            finished = true;
            Console.Clear();
            Console.WriteLine("Thank you for your business.");
            Checkout();
          }
          else
          {
            Console.Clear();
            Console.WriteLine("Sorry, that wasn't a valid option.");
          }
        }
      }
    }

    public static void Checkout()
    {
      int totalOrderCost = Bread.CalculatePurchaseCost() + Pastry.CalculatePurchaseCost();
      int normalCost = 0;

      if (BakedItem.GetPurchasedItemsCount() == 0)
      {
        Console.WriteLine("You did not purchase anything, see you next time.");
      }
      else
      {
        Console.WriteLine("Here are your items:");
        Console.WriteLine("--------------------");

        foreach (BakedItem item in BakedItem.GetPurchasedItems())
        {
          Console.WriteLine(item.Name + " - $" + item.Cost);
          normalCost += item.Cost;
        }

        Console.WriteLine("\nSubtotal - $" + normalCost);
        if (totalOrderCost < normalCost)
        {
          Console.WriteLine("Total - $ " + totalOrderCost + ". You saved $" + (normalCost - totalOrderCost) + ".");
        }
        else
        {
          Console.WriteLine("Total - $" + totalOrderCost);
        }
      }
    }

    public static void DisplayInventory()
    {
      int itemNumber = 1;

      Console.WriteLine("------------------------------------------------------");

      for (int i = 0; i < breadInventory.Count; i++)
      {
        Console.WriteLine(itemNumber + ". " + breadInventory[i].Name + " - $" + breadInventory[i].Cost);
        itemNumber++;
      }
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
      List<Bread> bakedBread = Bread.Bake();

      foreach (Bread item in bakedBread)
      {
        breadInventory.Add(item);
      }
    }

    public static void BakePastries()
    {
      List<Pastry> bakedPastry = Pastry.Bake();

      foreach (Pastry item in bakedPastry)
      {
        pastryInventory.Add(item);
      }
    }

    public static void Welcome()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. How can we help you today?");
      Console.WriteLine("SPECIAL: Buy two bread products and the third is free.");
      Console.WriteLine("SPECIAL: Buy three pastries for $5.");
    }
  }
}