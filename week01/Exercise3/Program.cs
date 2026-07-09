using System;

class Program
{
    static void Main(string[] args)
    {           
        string guess;
        int int_guess;
        int cont = 0;
        string play_again = "yes";
        do { 
        Random randomGenerator = new Random();
        int int_number = randomGenerator.Next(1, 100);
        

            do {
                    cont = cont + 1;
                    Console.Write("What is your guess?: ");
                    guess = Console.ReadLine();
                    int_guess = int.Parse(guess);

                    
                    if(int_guess> int_number)
                    {
                        Console.WriteLine("lower");
                    }
                    else if (int_guess < int_number)
                    {
                        Console.WriteLine("higuer");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!!");
                        Console.WriteLine($"You guessed it in {cont} trys");
                        Console.WriteLine("Do you want to play again?");
                        play_again = Console.ReadLine();
                        cont =0;
                    }
                
                } while (int_guess != int_number);
            } while (play_again == "yes");
    }
}