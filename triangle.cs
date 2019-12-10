using System; 
using System.Collections.Generic;

public class Triangle
{
    public int Side1;
    public int Side2;
    public int Side3;
//Why do we need feilds?

    public Triangle (int side1,int side2, int side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

// do we need public static on every method?

    public void TriangleChecker ()
    {
      if (this.Side1 ==  this.Side2 &&  this.Side3 ==  this.Side2)
      {
        Console.WriteLine("Equalateral Triangle");
      }  
      if (this.Side1 != this.Side3 && this.Side2 != this.Side3 && this.Side1 != this.Side2)
      {
        Console.WriteLine("Scalene Triangle");
      }
      if (this.Side1 == this.Side2 && this.Side2 != this.Side3)
      {
        Console.WriteLine("Isosceles Triangle");
      }
      if (this.Side1 == this.Side3 && this.Side2 != this.Side3)
      {
        Console.WriteLine("Isosceles Triangle");
      }
      if (this.Side2 == this.Side3 && this.Side1 !=this.Side3)
      {
         Console.WriteLine("Isosceles Triangle");
      }
    }

}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter your first side:");   
        int side1 = int.Parse(Console.ReadLine());

         Console.WriteLine("Enter your second side:");   
        int side2 = int.Parse(Console.ReadLine());

         Console.WriteLine("Enter your third side:");   
        int side3 = int.Parse(Console.ReadLine());
        Triangle firstTri = new Triangle(side1, side2, side3);   
        //do we need instance variable?
        firstTri.TriangleChecker();
      // why firstTri.TriangleCheker() does not work?   
    }
}