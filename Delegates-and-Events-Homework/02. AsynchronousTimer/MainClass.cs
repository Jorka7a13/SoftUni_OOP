namespace _02.AsynchronousTimer
{
    using System;

    public class MainClass
    {
        public static void printMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void beep(string message)
        {
            Console.Beep();
        }

        public static void Main()
        {
            AsyncTimer messageTimer = new AsyncTimer(printMessage, 100, 2000);
            messageTimer.Start();

            AsyncTimer beepTimer = new AsyncTimer(beep, 50, 2500);
            beepTimer.Start();
        }
    }
}