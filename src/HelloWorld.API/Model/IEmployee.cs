namespace HelloWorld.API.Model;

internal interface IEmployee
{
    int Id { get; set; }
    string Name { get; set; }
    decimal Salary { get; set; }
    int Age { get; set; }
}
