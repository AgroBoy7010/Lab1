// See https://aka.ms/new-console-template for more information

var a = new Person("Вася", "Петрович", "Пупкин");
var x = new Person[10];
var y = x.OrderBy(person => person.Name).ToArray();
Console.WriteLine(a);
public record Person(string Name,string LastName,string Patronomic,float Weight, DateTime Birthday)
{
    public int Age=> DateTime.Now.Year-Birthday.Year;
    public static Person Parse(string s)
    {
        var  array = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    }
}