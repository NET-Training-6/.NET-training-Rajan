//Constraints
//static
//Access modified = public,private,protected,internal
//public- has the highest visibility, anyone can get
//private- opposite to public
//internal- visility to project or assembly means yo particular project(hello app) bahek arule access garna sakdaina
class car
{
    public car()//constructor
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
        car car1 = new();
        car1.vendor = "Tesla";

        car.seats=34;

        Console.WriteLine();
    }
}