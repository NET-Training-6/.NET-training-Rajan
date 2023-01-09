
// Write a class for Rectangle, this child class should have methods to calculate area and perimeter
// Write a class for square, this child class should have methods to calculate area and perimeter
class Rectangle
{
  double length;
  double width;
  public Rectangle (double l, double w)
  {
    length = l;
    width = w;
  }

  public double GetArea() => length * width;
  public double GetPerimeter() => 2 *(length + width);
  public virtual void PrintDetails()
  {
     Console.WriteLine($"I am Rectangle with side l={length} and w={width}.");
  }

}
  
class Square : Rectangle // reusability concept
{
  double side;
  public Square(double s) : base(s,s) // base class is a inbuilt function
  {
    
  }
  public override void PrintDetails()
  {
     Console.WriteLine($"I am square with side S={side}.");
  }
}
// Write a class for Triangle, this child class should have methods to calculate area and perimeter
class Triangle: IShape
{
  double a; // If all are double we may also write double a, b,c
  double b;
  double c;
  public Triangle (double a, double b, double c)
  {
    this.a = a;
    this.b = b;
    this.c = c;
  }
   public double GetPerimeter() => a + b + c;
   public double GetArea()
   {
      var s = ( a + b + c)/2;
      var area = Math.Sqrt(s * (s-a)*(s-b)* (s-c));
      return area;
   }
   public void PrintDetails()
  {
     Console.WriteLine($"I am Triangle with side a ={a}, b ={b} and c = {c}");
  }
}

//Display details of all 2D shapes
interface IShape
{
    public void PrintDetails();
}
