class Entrypoint
{

    public static void Main()
    {
            
            Console.WriteLine("Enter the principle");
            var p = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time period");
            var t = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest");
            var r = float.Parse(Console.ReadLine());
            var i = p * t * r / 100;
            Console.WriteLine(" The required SimpleInterest is" + i);
            var a = p + i;
            Console.WriteLine("The required amount is" +a);
            Console.ReadLine();

      }
   
    }

    

