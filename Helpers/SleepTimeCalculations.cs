namespace Helpers
{
    public static class SleepTimeCalculations
    {
        public static string GetCurrentTime()
        {
            return DateTime.Now.ToString("HH:mm");
        }
    }

    public static class Meower
    {
        public static void Meow()
        {
            Console.WriteLine("meow");
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
