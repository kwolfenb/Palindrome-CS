using System;


namespace TriangleTracker
{

  class Triangle
  {
    private int Side1;
    private int Side2;
    private int Side3;


    public Triangle(int side1, int side2, int side3) // Constructor method for Car Class
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }
    public string Result ()
    {
      if (Side1 >= Side2+Side3 || Side2 >= Side1+Side3 || Side3 >= Side2+Side1)
      {
        return "It is not a triangle!";
      }
      else if (Side1==Side2 && Side3==Side2)
      {
        return "It is a Equilateral triangle!";
      }
      else if (Side1==Side2 || Side3==Side2 || Side1==Side3)
      {
        return "It is a Isosceles triangle!";
      }
      else
      {
        return "It is a Scalene triangle!";
      }
    }
  }
}
