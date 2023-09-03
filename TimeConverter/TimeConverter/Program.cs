
class TimeConverter
{
    public static void Main(string[] args) {
        Console.Write("Enter the time in seconds: ");
        long a = Convert.ToInt64(Console.ReadLine());
        long bakA = a;
        int year = 0;
        int month = 0;
        int day = 0;
        int hour = 0;
        int minute = 0;
        int seconds = 0;
        if (a >= 60*60*24*365) { year = Convert.ToInt32(a / (60*60*24*365)); a = a - (long) year * 365*24*60*60; }
        if (a >= 60*60*24*12) {month = Convert.ToInt32(a / (60*60*24*12)); a = a - (long)month * 12*24*60*60; }
        if (a >= 60*60*24) { day = Convert.ToInt32(a / (60*60*24)); a = a - (long)day * 24*60*60; }
        if (a >= 60*60) { hour = Convert.ToInt32(a / (60*60)); a = a - (long)hour * 60*60; }
        if (a >= 60) { minute = Convert.ToInt32(a / (60)); a = a - (long)minute * 60; }
        if (a >= 0) { seconds = Convert.ToInt32(a);}
        Console.WriteLine($"{bakA} seconds is {year}/{month}/{day} {hour}:{minute}:{seconds}");
        return;
    }
}