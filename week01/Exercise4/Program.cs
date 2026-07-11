using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {   int number;
        int total_sum = 0;
        int largest = 0;
        int smallest = 999999999;
        List<int> list_numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do {
            Console.Write("Please enter a number:  ");
            string num = Console.ReadLine();
            number = int.Parse(num);
            if(number != 0){ 
                list_numbers.Add(number);
            }
           }while(number != 0);

        foreach (int cont in list_numbers)
        {
            total_sum = total_sum + cont;
            if (cont> largest)
            {
                largest = cont;
            }
            if(cont < smallest && cont != 0)
            {
                smallest = cont;
            }
            
        } 
            
        list_numbers.Sort();
        double average = total_sum/ (list_numbers.Count -1);

        Console.WriteLine($"The sum is: {total_sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {largest}");
        Console.WriteLine($"The smallest is: {smallest}");
        
        foreach (int value in list_numbers)
            {
                Console.WriteLine(value);
            }

    }
}