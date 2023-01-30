using System;
using System.Collections.Generic;
class CollectionDictionary
{
    //list of something
   public void LearnLists()
    {
       
    }
    
    //Key- Value pair in dictionary
    public void LearnDictionary()
    {
       Dictionary<string, byte> people = new();
       people.Add("Santos", 25);
       people.Add("Bishnu", 35); 
       people.Add("Rahul", 15);
       people.Add("Mohit", 10);
       people.Add("Bom", 22);
       people.Add("Voj", 28);

       foreach( var person in people)
       {
        Console.WriteLine($"{person.Key} => {person.Value}");  
       }

    }

    // Create  a data structure to store country name, its population and area in square meter
    public void TupleList()
    {
       //(string CName, long population, double area) = ("Nepal", 347545546, 55445.56756);
       List<(string country, long population, double area)> countries = new();
       countries.Add(("Nepal", 347545546, 55445.56756));
       countries.Add(("India", 3475446545546, 55434345.56756));
       countries.Add(("China", 34754554466, 544545445.56756));
       
       foreach( var country in countries)
       {
        Console.WriteLine($"country : {country.country} \npopulation: {country.population} \narea: {country.area} \narea");   
       }

    }
}
