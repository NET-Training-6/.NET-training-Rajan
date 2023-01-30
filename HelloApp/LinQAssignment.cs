// Language INtegrated Query - LINQ
// Way / Technique to query collections

//ADO.NET - Database Query 
using System.Linq;

class LinqAssignment
{
    
    public void Assignment()
    {
        List<Country> countries = new()
        {
            new Country(name: "Nepal",continent:"Asia",area:21115.45,gdp:4500),
            new Country(name : "India",continent : "Asia",area : 17823783.23,gdp : 155478),
            new Country(name : "China",continent : "Asia",area : 9817823783.23,gdp : 125548),
            new Country(name : "Africa",continent : "Africa",area : 458165.23,gdp : 125547),
            new Country(name : "Indonesia",continent : "Europe",area : 7895462165.23,gdp : 110000),
            new Country(name : "Iran",continent : "Europe",area : 85216479.23,gdp : 122598),
            new Country(name : "Iraq",continent : "Asia",area : 12549877899.23,gdp : 125447),
            new Country(name : "Afghanistan",continent : "Asia",area : 1255879444.23,gdp : 9500),
            new Country(name : "Siria",continent : "Africa",area : 2265554778899.23,gdp : 965587),
            new Country(name : "Korea",continent : "Asia",area : 1222544888.23,gdp : 125587),
            new Country(name : "Thiland",continent : "Asia",area : 12226699774455.23,gdp : 1255879),
            new Country(name : "Australia",continent : "Australia",area : 9817823783.23,gdp : 7895547),
            new Country(name : "United States",continent : "South Ameria",area : 78555549955.23,gdp : 336698554)
        };

        //Sorting countries by area
        var countriesByArea = countries.OrderBy(country => country.area);
        //Expression syntax
        countriesByArea = from country in countries orderby country.area select country;
        foreach (var country in countriesByArea)
        {
            Console.WriteLine($"Country : {country.name}, Area : {country.area.ToString("N0")} ");
        }

        //sorting countries by their gdp
        var countriesByGDP = countries.OrderBy(country => country.gdp);
        //Expression syntax 
        countriesByGDP = from country in countries orderby country.gdp select country;
        Console.WriteLine("\n\n");
        foreach (var country in countriesByGDP)
        {
            Console.WriteLine($"Country : {country.name}, GDP : {country.gdp.ToString("N0")} ");
        }

        //Sorting asian file

    }
    
}

class Country
{
    public string name;
    public string continent;
    public double area;
    public double gdp;

    public Country(string name, string continent, double area, double gdp)
    {
        this.name = name;
        this.continent = continent;
        this.area = area;
        this.gdp = gdp;

    }

}

