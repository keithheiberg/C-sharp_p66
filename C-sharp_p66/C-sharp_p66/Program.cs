using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        string firstStringNumber = Console.ReadLine();
        double firstNumber = Convert.ToDouble(firstStringNumber);
        double product = firstNumber * 50.0;
        Console.WriteLine("Your number * 50 = " + product);

        Console.WriteLine("Please enter another number: ");
        string secondStringNumber = Console.ReadLine();
        double secondNumber = Convert.ToDouble(secondStringNumber);
        double sum = secondNumber + 25.0;
        Console.WriteLine("Your number + 25 = " + sum);

        Console.WriteLine("Please enter another number: ");
        string thirdStringNumber = Console.ReadLine();
        double thirdNumber = Convert.ToDouble(thirdStringNumber);
        double quotient = thirdNumber / 12.5;
        Console.WriteLine("Your number / 12.5 = " + quotient);

        Console.WriteLine("Please enter another number: ");
        string fourthStringNumber = Console.ReadLine();
        double fourthNumber = Convert.ToDouble(fourthStringNumber);
        bool overFifty = fourthNumber > 50.0;
        Console.WriteLine("Is your number > 50? " + overFifty);

        Console.WriteLine("Please enter another number: ");
        string fifthStringNumber = Console.ReadLine();
        double fifthNumber = Convert.ToDouble(fifthStringNumber);
        double remainder = fifthNumber % 7.0;
        Console.WriteLine("Your number / 7, remainder = " + remainder);

        Console.ReadLine();
    }
}
