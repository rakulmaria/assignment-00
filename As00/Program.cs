

public class Program 
{
    public static void Main(string[] args) 
    {
        var p = new Program();

        try 
        {
            var input = Console.ReadLine();
            var tmp = p.IsLeapYear(input);
            var res = p.YayOrNay(tmp);
            Console.WriteLine(res);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

    }
    public bool IsLeapYear(string input)
    {
        int val;

        if (int.TryParse(input, out val) == false)
            throw new FormatException(input + " is not a valid input. Input must be of type int.");

        var year = Int32.Parse(input);

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
