class Animal
{
    //COnstructor is made because field like noOfLegs, isDomestic can be easily accessed to 
    //default constructor
    public Animal()
    {

    }

    // Parameterized constructor
    public Animal(string an, bool Domestic)
    {
       animalName = an;
       this.isDomestic = Domestic;
    }
    public string animalName;
    public int noOfLegs;
    public bool isDomestic; //default value of boolean is false

}

class Test
{
    void Test1()
    {
        //Animal animal1 = new();
        //animal1.animalName = "Dog";
        //animal1.isDomestic = true;

        Animal animal2 = new();
        Animal animal1 = new Animal("Dog", true);
       

    }
}

//