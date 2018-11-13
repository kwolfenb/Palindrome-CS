using System;
using System.Collections.Generic;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter the first side of your triangle: ");
      string firstSide = Console.ReadLine();
      int side1 = int.Parse(firstSide);
      Console.WriteLine("Enter the second side of your triangle: ");
      string secondSide = Console.ReadLine();
      int side2 = int.Parse(secondSide);
      Console.WriteLine("Enter the third side of your triangle: ");
      string thirdSide = Console.ReadLine();
      int side3 = int.Parse(thirdSide);
      Triangle triangle = new Triangle(side1,side2,side3);
      Console.WriteLine(triangle.Result());
    }
  }
}
