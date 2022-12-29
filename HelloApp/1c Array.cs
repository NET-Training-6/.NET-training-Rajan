class ArrayLearner
{
    public void LearnArray()
    {
    //    //one dimensional array 
    //    byte[] ages = {56, 87, 23, 6, 70}; //array le eutaii variable ma homogeneous data collection rakhxa
    //    var x = ages[4]; // xa ma 70 basxa
    //    //ages[5]= 33; //ages ko 6th item 33 set gareko ho(setter)
    //    var numbers = new int[100]; // 100 wata vanda badhi hold garna sakdaiina
    //    var l = ages.Length;// to calculate length
    //    Console.WriteLine(l);
       
    //    //Multi dimensional array
    //    double[,] matrix = new double[2,2]; // or var matrix = new double[3,4];  if we don't want to put commas
    //    //44 34
    //    //34 23 example denoting 2*2 matrix

    //    matrix[0,0] = 45;
    //    matrix[0,1] = 55;
    //    matrix[1,0] = 65;
    //    matrix[1,1] = 75;

    //    //Jagged array
    //    var jArray = new decimal[20][];
    //    jArray[0] = new decimal[]{2,3,4,5,7};
    //    jArray[1] = new decimal[]{21,30,45};

    //LearnArray al = new LearnArray();
    //al.LearnArray();
    string[] names = new string[10] {"Ram", "Nikhil","Binodh", "Dilip", "Rahul", "Mohit", "Aryan","Bablu", "Dablu", "Prachanda"};
    foreach(var name in names)
    {
        Console.WriteLine(name);
    }
    int[] salaries = new int[6]{1500, 2000, 23000, 3200, 5500,4400};
    int maxSalary = 0;
    foreach (int salary in salaries)
    {
        if(salary> maxSalary)
        {
            maxSalary = salary;
        }
    }
    Console.WriteLine(maxSalary);
    Console.ReadKey();
    }
}