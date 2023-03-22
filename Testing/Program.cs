// See https://aka.ms/new-console-template for more information

using MindboxTest;

Console.WriteLine("Hello, World!");

Figure figure = new Triangle(4, 4, 4);

Console.WriteLine(figure.CalculateArea());

figure = new Circle(2147483647);
Console.WriteLine(figure.CalculateArea());

Console.ReadLine();