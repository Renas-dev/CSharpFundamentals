namespace Helpers
{
    public static class SleepTimeCalculations
    {
        public static string GetCurrentTime()
        {
            return DateTime.Now.ToString("HH:mm");
        }

        public static void RunMenu()
        {
            Console.WriteLine("Enter 1 to see ur current best times to go to bed, 2 to choose when to go to bed, 3 to choose when to wake up");
            while(true)
            {
                string? input = Console.ReadLine();
                if (input == "1"){
                    SleepNowCalculations.SleepNowCalculation();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Enter your desired time to wake up at:");
                    string? userTime = Console.ReadLine();
                    WakeUpAtCalculations.WakeUp(userTime !);
                }
                else if (input == "3")
                {
                    Console.WriteLine("Enter your desired time to go to bed at");
                    string? userTime = Console.ReadLine();
                    SleepAtCalculations.SleepAt(userTime !);
                }else
                {
                    Console.WriteLine("Please type in 1, 2 or 3");
                }
            }
        }
    }

    public static class SleepNowCalculations
    {
        public static void SleepNowCalculation()
        {
            for (int i = 0; i < 6; i++)
            {
                DateTime now = DateTime.Now;
                int minutesToAdd = 90 * (i + 1);
                DateTime bedTime = now.AddMinutes(minutesToAdd);
                Console.WriteLine("Cycle " + (i + 1) + ": " + bedTime.ToString("HH:mm"));
            }
        }
    }

    public static class WakeUpAtCalculations
    {
        public static void WakeUp(string userTime)
        {
            DateTime time = DateTime.ParseExact(userTime, "HH:mm", null);
            for (int i = 0; i < 6; i++)
            {
                int minutesToSubtract = 90 * (i + 1);
                DateTime bedTime = time.AddMinutes(-minutesToSubtract);
                Console.WriteLine("Cycle " + (i + 1) + ": " + bedTime.ToString("HH:mm"));
            }
        }
    }
    public static class SleepAtCalculations
    {
        public static void SleepAt(string userTime)
        {
            DateTime time = DateTime.ParseExact(userTime, "HH:mm", null);
            for (int i = 0; i <6; i++)
            {
                int minutesToAdd = 90 * (i + 1);
                DateTime bedTime = time.AddMinutes(minutesToAdd);
                Console.WriteLine("Cycle " + (i + 1) + ": " + bedTime.ToString("HH:mm"));
            }
        }
    }
}
