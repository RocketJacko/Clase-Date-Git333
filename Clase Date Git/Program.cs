// See https://aka.ms/new-console-template for more information
using Clase_Date.Clases;

Console.WriteLine("Bienvenidos");



try
{

    Console.WriteLine(new Date(30, 1, 2024));
    Console.WriteLine(new Date(29, 2, 2024));
    Console.WriteLine(new Date(31, 11, 2024));
    Console.WriteLine(new Date(28, 2, 2023));
    Console.WriteLine(new Date(28, 2, 2023));
}
catch (Exception error)
{
    Console.WriteLine(error.Message + "error");

}



