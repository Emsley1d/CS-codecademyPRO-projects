using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double rectangleArea = Rectangle(2500, 1500);
      double circleArea = Circle(375);
      double triangleArea = Triangle(750, 500);
      double area = rectangleArea + triangleArea + (circleArea / 2);
      double cost = Math.Round(area * 180, 2);


      Console.WriteLine($"Rectangle Area = {rectangleArea}m");
      Console.WriteLine($"Circle Area = {circleArea}m");
      Console.WriteLine($"Triangle Area = {triangleArea}m");
      Console.WriteLine($"Total Areas is {area}m");
      Console.WriteLine($"The plan costs: {cost} pesos");

      static double Rectangle(double length, double width){
        return length * width;
      }


      static double Circle(double radius){
        return Math.PI * Math.Pow(radius, 2);
      }

      static double Triangle(double bottom, double height){
        return 0.5 * bottom * height;
      }

    }
  }
}