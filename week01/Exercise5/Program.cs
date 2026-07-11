using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();
       string user_name = PromptUserName();
       int favorite_number = PromptUserNumber();
       int square_number = SquareNumber(favorite_number);
       DisplayResult(square_number,user_name);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
         Console.Write($"Whats your name: ");
         string name = Console.ReadLine();
         Console.WriteLine($"Hello {name}");
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write($"Whats your favorite number?:");
        string number = Console.ReadLine();
        int fav_num = int.Parse(number);
        return fav_num;
    }
    static int SquareNumber(int user_number)
    {
        int number = user_number * user_number;      
        return number;
    }
    static void DisplayResult(int user_number, string user_name)
    {
        Console.Write($"{user_name}, the square of your number is:{user_number}");
    }
    
}