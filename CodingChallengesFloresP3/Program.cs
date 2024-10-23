using System;
using System.Numerics;

class Challeneges
{
    private static int number;

    public static void Main(string[] args, string number4)
    {
        Console.WriteLine("Welcome to my coding challenge program. There will be a variety of different functions you will have to choose from. \nPlease pick one.");

        Console.WriteLine("Today we are going to use the number adder called SUM. Please input two numbers for us to add. \n");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("Awesome! Please input a second number");

        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);

        Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to:" + Sum(number1int, number2int));
       
        
        Console.WriteLine("Lets try converting minutes into seconds. \nGive me a number to convert from minutes into seconds.");
        Console.WriteLine("Input a number that you would like to see converted into seconds");
        var number3 = Console.ReadLine();
        int number2int3 = int.Parse(number3);
        Console.WriteLine(number3 + " minutes converted into seconds is ", Convert(

        Sum(number1int, number2int);

        Console.WriteLine("Input any number that you would want as your voltage, to get a caluculated power for your circuit power.");
        var number4 = Console.ReadLine();
        int number4int = int.Parse(number4);
        Console.WriteLine("Input another value to add as your current" );
        var number5 = Console.ReadLine();
        int number5int = int.Parse(number5);

        Console.WriteLine("Great! Heres what your calculated power will be:" + ); 
    }
    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Convert(string number3, int number)
    {
        return number * 60;
    }

    public static int CircuitPower(int number4, int number5)
    {
        return (number4 + number5) * 10;
    }
}




