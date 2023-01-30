
class CollectionLearner
{
    //list of something
   public void LearnLists()
    {
        List<int> numbers = new List<int>(){577576,57678,6688};
        numbers.Add(3422);
        numbers.Add(3402);
        numbers.Add(3922);
        numbers.Remove(3122);

        foreach(var num in numbers)
        {
          Console.WriteLine(num);  
        }

        //Create list to store name of 5 people
    }
    //Create list to store name of 5 people
    //Create all name in console in upper case which are less tha five character
    public void AddPeople()
    {
        List<string> people = new List<string>(){"Santos", "Badr", "Saroj", "Bom", "Pujan"};
        foreach(var p in people)
        {
            if(p.Length<5)
            Console.WriteLine(p.ToUpper());
        }
    }
}