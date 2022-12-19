class Entrypoint
{

    public static void Main()
    {

        //  Console.WriteLine("BMI Calculator");
        //  Console.WriteLine("Enter the height in metrer");
        //  var height = float.Parse(Console.ReadLine());
        //  Console.WriteLine("Enter the weight in kg");
        //  var weight = float.Parse(Console.ReadLine());
        //  var bmi = weight / (height*height);
        //  Console.WriteLine("The required BMI of the value is " + bmi );
        //  Console.ReadLine();

        // Console.WriteLine("Enter a number");
        // var number = int.Parse(Console.ReadLine());
        // if (number % 3 == 0 && number % 5 == 0)
        // {
        //     Console.WriteLine(number + "is multiple of 3 and 5");
        // }
        // else if (number % 5 == 0)
        // {
        //     Console.WriteLine("Only multiple of 5");
        // }
        // else if (number % 3 == 0)
        // {
        //     Console.WriteLine("Only multiple of 3");
        // }
        // else
        // {
        //     Console.WriteLine(number + " is not divisible by 3 or 5");
        //}

        Console.WriteLine("Principle");
        var p = double.Parse(Console.ReadLine());

        Console.WriteLine("Time(Years)");
        var t = double.Parse(Console.ReadLine());

        Console.WriteLine("rate(%)");
        var r = double.Parse(Console.ReadLine());

        var ci = p * Math.Pow((1+r/100),t) - p;

        //Console.WriteLine("Required compound interest of" +p + "for" +t + "years, at" +rText + "% is" +ci);
              
        //String Manipulation
        Console.WriteLine($"Required compound interest of {p} for {t} years at {r}% is {ci}");

        


    }

}



