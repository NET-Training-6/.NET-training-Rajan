class Entrypoint
{

    public static void Main()
    {

        Console.WriteLine("Please enter a number");
        var number = int.Parse(Console.ReadLine());
        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine(number + " is divided by both 3 and 5 ");
        }
        else
        {
            Console.WriteLine(number + " is not divided by both 3 and 5 ");
        }

    }

}



