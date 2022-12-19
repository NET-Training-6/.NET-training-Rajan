class Entrypoint
{

    public static void Main()
    {

     Console.WriteLine("BMI Calculator");
     Console.WriteLine("Enter the height in metrer");
     var height = float.Parse(Console.ReadLine());
     Console.WriteLine("Enter the weight in kg");
     var weight = float.Parse(Console.ReadLine());
     var bmi = weight / (height*height);
     Console.WriteLine("The required BMI of the value is " + bmi );
     Console.ReadLine();
       

    }

}



