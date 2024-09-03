// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var a = new Person("Вася", "Петрович", "Пупкин");
public record Person(string Name,string LastName,string Patronomic,float Weight, DateTime Birthday)
{
    public int Age=> DateTime.Now.Year-Birthday.Year;
}