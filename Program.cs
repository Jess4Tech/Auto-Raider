using System;
using WindowsInput.Native;
using WindowsInput;


namespace AutoRaid
{
    class Program
    {
        static void Main(string[] args)
        {
            InputSimulator simulator = new InputSimulator();
            Console.WriteLine("What message do you want to spam?");
            string spamLine = Console.ReadLine();
            static void openPrivate()
            {
                string privateBrowser = "/C start microsoft-edge:http://www.discordapp.com/";
                System.Diagnostics.Process.Start("CMD.exe", privateBrowser);
            }
            openPrivate();
            Console.ReadKey();
            while (true)
            {
                try
                {
                    simulator.Keyboard.TextEntry(spamLine).KeyPress(VirtualKeyCode.RETURN).Sleep(1000);
                } catch (System.Exception)
                {
                    break;
                }
            }
            
        }
    }
}
