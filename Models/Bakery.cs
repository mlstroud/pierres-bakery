namespace Bakery.Models
{
  public class Bread
  {
    public string Name { get; set; }
    public float Cost { get; set; }

    public Bread(string name, float cost)
    {
      Name = name;
      Cost = cost;
    }
  }

  public class Pastry
  {
    public string Name { get; set; }
    public float Cost { get; set; }

    public Pastry(string name, float cost)
    {
      Name = name;
      Cost = cost;
    }
  }
}