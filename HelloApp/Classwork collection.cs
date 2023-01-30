using System.Collections.Generic;
using System;
class CollectionSolution
{
    //Create list of at least 10 numbers and print in console only the numbers multiple of 3 an 5

    public void ListNumbers()
    {
        List<long> numbers = new List<long>() { 5435, 6557, 333, 345, 7576, 654650, 2342, 687, 666, 3344, 6677 };
        // var x = 4 & 3;
        foreach (long num in numbers)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.Write($"{num} ");
            }

        }
    }
    //Create list of date of births of 8 people. Print those dobs in console oldest first.
    public void ListDobs()
    {
        List<DateTime> dobs = new List<DateTime>
          {
             new DateTime(1988, 12, 12),
             new DateTime(1989, 02, 12),
             new DateTime(1978, 12, 10),
             new DateTime(1980, 12, 23),
             new DateTime(1988, 08, 11),
             new DateTime(2018, 02, 22),
          };

        dobs.Sort();
        foreach (DateTime dob in dobs)
        {
            Console.WriteLine(dob.ToString("MMMM dd, yyyy"));
        }

    }

}