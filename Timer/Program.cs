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
        string[] commands;
        ArrayList threads = new ArrayList();
        bool valid = true;
        Console.WriteLine("How to use:\n" +
                          "startTimer <name> <seconds>");
        
        
        while (true)
        {
            input = Console.ReadLine();
            commands = input.Split(" ");
            
            //Console.WriteLine(commands.Length+commands[0]+commands[1]+commands[2]);
            
            if (commands.Length!=3)
            {
                Console.WriteLine("Falsche Eingabe!!\n Eingabe wird ignoriert.");
                valid = false;
            }

            if (valid)
            {
                command = commands[0];
                commandName = commands[1];
                valid = Int32.TryParse(commands[2], out commandTime);
                
                if (command.Equals("startTimer"))
                {
                    TimerThread thread = new TimerThread(commandName, commandTime);
                    Thread temp = new Thread(thread.runTimer);
                    temp.Start();
                    threads.Add(temp);
                }
            }

            valid = true;
        }
    }
}