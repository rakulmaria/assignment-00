

public class Program 
{
    public static void Main(string[] args) 
    {
        var p = new Program();

        var input = Console.ReadLine();
        var year = Int32.Parse(input);
        var tmp = p.IsLeapYear(year);
        var res = p.YayOrNay(tmp);

        Console.WriteLine(res);

    }
    public bool IsLeapYear(int year)
    {
        if (year < 1582) 
            throw new ArgumentOutOfRangeException(year + " is an invalid leap year. Leap year should be greater than 1582.");
        
        if (year%4 == 0) {
            if (year%100 == 0) {
                if (year%400 == 0) return true;
                else return false;
            } else return true;
        }
        else return false;
    }

    public string YayOrNay(bool ans) 
    {
        if(ans == true) return "yay";
        else return "nay";
    }

    // public bool ErrorHandling(string tmp) 
    // {
    //     bool = false;
    //     try {


    //     } catch (ArgumentOutOfRangeException e) 
    //     {
    //         WriteLine($"Error: {e.Message}");
    //     }
    // }

}
