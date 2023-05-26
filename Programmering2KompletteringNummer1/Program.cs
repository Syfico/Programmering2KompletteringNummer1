using System;

namespace Programmering2KompletteringNummer1;

public class Engine
{
    public void Start()
    {
        Console.WriteLine("Tjohoo! Bilen startar!!");
    }


    public void Stop()
    {
        Console.WriteLine("Jahopp, nu stannade bilen");
    }
}

public class Car
{
    private Engine engine;

    public Car()
    {
        engine = new Engine(); 
    }

    public void StartCar()
    {
        engine.Start();
    }
   
    public void StopCar()
    {
        engine.Stop();
    }
}

public class Dacia : Car
{
}

public class Volkswagen : Car
{
}

public class Porsche : Car
{
}

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        car.StartCar();
        car.StopCar();
    }
}