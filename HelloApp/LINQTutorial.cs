

class Linq
{
    int[] numbers = { 2, 0, 3, 4, 5, 56, 12, 10, 23, 45, 67, 40 };
    List<string> names = new() { "Bishnu", "Sagar", "Prem", "Kran", "Sajan", "Naresh" };
    List<Employee> employees = new()
    {
        new Employee(){Name = "santish", Age = 27, Department = "HR", Designation = "Enginer"},
        new Employee() {Name = "Rajan", Age = 20, Department = "SE", Designation ="Peon"},
        new Employee() {Name = "Rajwn", Age = 21, Department = "SE", Designation ="clerk"},
        new Employee() {Name = "sajan", Age = 20, Department = "SE", Designation ="HOD"},
        new Employee() {Name = "Rawan", Age = 20, Department = "HR", Designation ="Head"},
    };

    public void LearnTOQueryCOmplexCollection()
    {
        //get all employees in HR department
        var EmployeeesInHRDept = employees.Where(employee => employee.Department=="HR");

        //get name of employees in HR department
        var EmployeesNameINHR = employees.Where(employee => employee.Department=="HR").Select(employee => employee.Name);

        // get all SE under the age of 22

        var softwareEngineersUndeAge22 = employees.Where(employee => employee.Department=="SE" && employee.Age <22);

        foreach (var employee in softwareEngineersUndeAge22)
        {

            Console.WriteLine(employee.Name);
        }
    }



    public void Test()
    {
        // Filters
        //1. Get all even numbers in "numbers"
        var evenNums = numbers.Where(num => num % 2 == 0);

        // similar work but different syntax of above solutions done. You can choose any among those.
        //Solutions in one line or from three line using syntax like sql query.
        evenNums = from num in numbers
                   where num% 2 == 0
                   select num;

        //2. Get all odd numbers in "numbers"
        var oddNums = numbers.Where(num => num % 2 != 0);

       
        oddNums = from num in numbers
                   where num% 2 != 0
                   select num;

        //3. Get all numbers which ends with "0"        
        var numsEnding0 = numbers.Where(num => num.ToString().EndsWith("0"));

        // Projections
        //4. Get squares of all numbers in "numbers" array
        var squares = numbers.Select(num => num * num);

        foreach (var n in squares)
        {
            Console.WriteLine(n);
        }

        //5. Get squares of elements which are greater than 50

        //6. Get all person names which starts with letter 'A' in "names" list
        var namesStartingA = names.Where(n => n.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));

        //7. From "names" list, get all person names with less than 4 characters 
        // and convert them to uppercase

    }
}

class Employee
{
    public string Name {get; set;}
    public int Age {get; set;}
    public string Department {get; set;}

    public string Designation {get; set;}

}
