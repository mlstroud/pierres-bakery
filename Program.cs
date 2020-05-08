using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    List<Bread> breadInventory;
    List<Pastry> pastryInventory;

    public static void Main()
    {
      OpenStore();
      Welcome();
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
      Bread baguette = new Bread("Baguette", 4.99);
      Bread brioche = new Bread("Brioche Ball", 3.99);
      Bread ficelle = new Bread("Ficelle", 5.99);

      breadInventory.Add(baguette);
      breadInventory.Add(brioche);
      breadInventory.Add(ficelle);
    }

    public static void BakePastries()
    {
      Pastry bearClaw = new Pastry("Bear Claw", 3.99);
      Pastry danish = new Pastry("Danishh", 4.99);
      Pastry turnover = new Pastry("Turnover", 5.99);

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