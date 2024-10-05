// See https://aka.ms/new-console-template for more information
using DesignPatterns;

Console.WriteLine("Hello, World!");

Logistics logistics = new LandLogistics();
Console.WriteLine("Enter the size of the goods in kg");
var goodWeight = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the goods");
var good = Console.ReadLine();
if (goodWeight > 500)
{
    logistics = new AirLogistics();
}
logistics.DeliverGood(good);