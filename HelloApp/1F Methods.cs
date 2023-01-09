class MethodLearner
{
    //write a method takes that an number array and return average of those
    public double CalculateAverage(params double[] numbers)// users of params doesn't let us create array in entry point
    {
        double totalSum = 0; // It is written instead of sum = num1 + num2+ nu
        foreach(double number in numbers)
        {
            totalSum = totalSum + number;
        }
        double average = totalSum/numbers.Length;
        Console.WriteLine(average);
        return average;
    }

    // Write a method that takes bunch of numbers and return minimum among them

    public double FindMinimum(params double[] numbers)// users of params doesn't let us create array in entry point
    {
        var minimumNumber = numbers[0];// parameter ko first numberlaii minimum manya ho
        foreach(int number in numbers)
        {
          if(number < minimumNumber)
          {
            minimumNumber = number;
          }
        }
        Console.WriteLine(minimumNumber);
        return minimumNumber;
    }

    // Sum and product in same program
    public (int,int)  GetSumAndProduct(byte n1, byte n2) // It is tuple
    {
        var s = n1 + n2;
        var p = n1 * n2;
        Console.WriteLine(s);
        Console.WriteLine(p);
        return (s,p);
    }
} 