using Humanizer;

Console.WriteLine("Por favor ingrese su nombre");
var nombre = Console.ReadLine();
Console.WriteLine("Por favor ingrese su cargo");
var cargo = Console.ReadLine();
Console.WriteLine("Por favor ingrese su edad");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Mi nombre es {nombre}, mi cargo es {cargo}, mi edad es {edad.ToWords()}");
