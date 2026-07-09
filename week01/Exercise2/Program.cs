using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write your grade percentage:");
        string number = Console.ReadLine();
        int x = int.Parse(number);
        string letter = "A";

        if (x >= 90) {
            letter = "A";}
        else if(x>= 80){
            letter = "B";
        }
        else if (x>= 70) {
            letter = "C";
        }
        else if (x>= 60) {
            letter = "D";
        }
        else if (x<60) {
            letter = "F";
        }
        
        
        int digit = x%10 ;
        string sign ;
        if (digit >= 7 && letter != "A" || letter != "F"){
            sign = "+";
        }
        else if (digit <= 7 && letter != "A" || letter != "F")
        {
            sign = "-";
        }
        else
        {
            sign =" ";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");     
       
        if (x >= 70)
        {
            Console.WriteLine("Congratulations you passed the course");       
        }
        else
        {
            Console.WriteLine("You didn't pass. Better luck next time!");
        }
      

       
    
    }
}