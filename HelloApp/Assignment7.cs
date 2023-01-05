class Laptop
{
    string name;
    string brand;
    int ramGB;
    string processor;
    double screenSize;

    public Laptop(string name, string brand, int ram, string processor, double screenSize)
    {
        this.name = name;
        this.brand = brand;
        this.ramGB = ram;
        this.processor = processor;
        this.screenSize = screenSize;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Name : {name} \n Brand : {brand} \n Ram : {ramGB} \n Processor : {processor} \n Screen Size : {screenSize}");
    }

}

class Dell : Laptop, IDisplayLaptopInfo
{
    string name;
    string color;

    public Dell(string name, string color) : base(name, "Dell", 4, "QuadCore", 15.6)
    {
        this.name = name;
        this.color = color;
    }

}

class MSI : Laptop, IDisplayLaptopInfo
{
    string name;
    string color;

    public MSI(string name, string color) : base(name, "MSI", 16, "QuadCore", 14)
    {
        this.name = name;
        this.color = color;
    }
}

interface IDisplayLaptopInfo
{
    public void PrintInfo();
}