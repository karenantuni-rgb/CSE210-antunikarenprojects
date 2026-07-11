using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //this is a comment
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._JobTitle = "Developer";
        job1._company = "Apple";
        job1._starYear = 2019;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._JobTitle = "Engineer";
        job2._company = "Microsoft";
        job2._starYear = 2021;
        job2._endYear = 2022;



        Resume myResume = new Resume();
        myResume._name = "Karen";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
               
        myResume._DisplayAll();

        
    }
}