namespace Timer;
using System.Threading;

public class TimerThread
{
    private string name;
    private int seconds;

    public TimerThread(string name, int seconds)
    {
        this.name = name;
        this.seconds = seconds;
    }
    public void runTimer()
    {
        try
        {
            DateTime start=DateTime.Now;
            DateTime end = start.Add(TimeSpan.FromSeconds(seconds));
            Console.WriteLine("The Timer "+name+" started at: "+start.Hour+":"+start.Second+"and will end at"+end.Hour +":"+ end.Second);
            Console.WriteLine(start.CompareTo(end));
            while (start.CompareTo(end)>1)
            {
                Thread.Sleep(1000);
            }
            Console.WriteLine("The Time of Timer "+name+ "is over!! ("+end.Subtract(start)+")");


        }
        catch (Exception e)
        {
            Console.WriteLine("Time Thread Exeption:\n"+e);
            throw;
        }
    }
}