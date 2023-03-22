// See https://aka.ms/new-console-template for more information
using MindboxTest;

Console.WriteLine("Hello, World!");

IFigure figure = new Circle(5);
var a = figure.ValidateFigure();

var b = figure.CalculateArea();

Console.WriteLine(a);
Console.WriteLine(b);
Console.ReadLine();