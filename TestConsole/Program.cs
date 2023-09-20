// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

var culture = new CultureInfo("es");
Console.WriteLine($"Running with culture {culture.NativeName}");
