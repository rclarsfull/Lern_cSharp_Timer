using System.Collections;
namespace Timer;
class Timer
{
    public static void Main()
    {
        string input = "";
        string command = "";
        string commandName = "";
        int commandTime = 0;
        string[] commands = input.Split(" ");
        ArrayList threads = new ArrayList();
        bool valid = true;
        
        
        while (true)
        {
            input = Console.ReadLine();
            if (commands.Length!=3)
            {
                Console.WriteLine("Falsche Eingabe!!\n Eingabe wird ignoriert.");
                valid = false;
            }

            command = commands[0];
            commandName = commands[1];
            valid=Int32.TryParse(commands[2], out commandTime);

            if (valid &&command.Equals("startTimer"))
            {
                TimerThread thread = new TimerThread(commandName, commandTime);
                Thread temp = new Thread(thread.runTimer());
                temp.Start();
                threads.Add(temp);
            }

            valid = true;
        }
    }
}