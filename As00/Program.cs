

public class Program 
{
    public static void Main(string[] args) 
    {
        var p = new Program();

        var input = Console.ReadLine();
        var year = Int32.Parse(input);
        var tmp = p.IsLeapYear(year);
        var res = p.yayOrNay(tmp);

        Console.WriteLine(res);

    }
    public bool IsLeapYear(int year)
    {
        if (year%4 == 0) {
            if (year%100 == 0) {
                if (year%400 == 0) return true;
                else return false;
            } else return true;
        }
        else return false;
    }

    public string yayOrNay(bool ans) {
        if(ans == true) return "yay";
        else return "nay";
    }

}
