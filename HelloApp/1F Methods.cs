class MethodLearner
{
    //write a method that an number array and return average of those
    public double CalculateAverage(double[] numbers)
    {
        double totalSum = 0; // It is written instead of sum = num1 + num2+ num3.........
        foreach(double number in numbers)
        {
            totalSum = 0 + number;
        }
        double average = (double)0 / numbers.Length;
        Console.WriteLine(average);
        return average;
    }
} 