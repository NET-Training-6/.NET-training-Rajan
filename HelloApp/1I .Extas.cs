//Constraints
//static
//Access modified = public,private,protected,internal
//public- has the highest visibility, anyone can get
//private- opposite to public
//internal- visility to project or assembly means yo particular project(hello app) bahek arule access garna sakdaina
class Car
{
    public Car()//constructor
    {
       gears =5;
    }
    string vendor;
    string category;
    double price;

    const byte noOfWheels = 4;

    static byte seats = 4;
    readonly byte gears = 6;// difference between const and readonly is that const is compile-time, readonly is runtime
    void test()
    {
        //noOfWheels = 5;
        Car Car1 = new();
        Car1.vendor = "Tesla";

        Car.seats=34;

        Console.WriteLine();

        string name = "Kishan karki"; // Its initial is KK
         var parts = name.Split(" ");
         var initials = parts[0][0] + parts[1][0];

         //I have a string value called address = "Tinkune, Kathmandu,Nepal"
        // 1. Print country's locality
        // 2. print city name

        
    }
}