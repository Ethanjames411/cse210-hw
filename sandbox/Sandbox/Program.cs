using System;
using System.Globalization;
using Sandbox;
class Program
{
    static void Main(string[] args)
    {
        DisplayBlind();
    }
    static void DisplayBlind()
    {
        var kitchen = new Blind();

        kitchen._Width = 100;
        kitchen._Height = 70;
        kitchen._Color = "Red";
        var materialAmont = kitchen.GetArea();

        Console.WriteLine($"Width: {kitchen._Width}");
        Console.WriteLine($"Height: {kitchen._Height}");
        Console.WriteLine($"Color: {kitchen._Color}");
        Console.WriteLine($"Material Amount: {materialAmont}");

        var ethanHouse = new House();
        ethanHouse._Owner = "Ethan James Walker";
        ethanHouse._Kitchen._Width = 60;
        ethanHouse._Kitchen._Height = 80;
        ethanHouse._Kitchen._Color = "Blue";
        var kitchenMaterialAmount = ethanHouse._Kitchen.GetArea();

        Console.WriteLine($"Owner: {ethanHouse._Owner}");
        Console.WriteLine($"Kitchen Width: {ethanHouse._Kitchen._Width}");
        Console.WriteLine($"Kitchen Height: {ethanHouse._Kitchen._Height}");
        Console.WriteLine($"Kitchen Color: {ethanHouse._Kitchen._Color}");
        Console.WriteLine($"Kitchen Material Amount: {kitchenMaterialAmount}");

        ethanHouse._Blinds.Add(kitchen);

        foreach (var blind in ethanHouse._Blinds)
        {
            Console.WriteLine($"Blind Width: {blind._Width}");
            Console.WriteLine($"Blind Height: {blind._Height}");
            Console.WriteLine($"Blind Color: {blind._Color}");
            Console.WriteLine($"Blind Material Amount: {blind.GetArea()}");
        }

    }
}