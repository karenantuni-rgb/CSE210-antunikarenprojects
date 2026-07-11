public class Job
{
   public string _company;
    public string _JobTitle;
    public int _starYear ;
    public int _endYear;
    public void Display()
    {
        Console.WriteLine($"{_JobTitle}  ({_company}) {_starYear} - {_endYear}");
    }
}