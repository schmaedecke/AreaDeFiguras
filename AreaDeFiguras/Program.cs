﻿using AreaDeFiguras.Entities;
using AreaDeFiguras.Entities.Enums;
using System;
using System.Globalization;

namespace AreaDeFiguras
{
    internal class Program {
        static void Main(string[] args) {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i+1} data: ");
                Console.Write("Rectangle or circle (r/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Blue/Black/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }else if(ch == 'c') {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    list.Add(new Circle(radius,color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS");
            foreach(Shape shape in list) {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}