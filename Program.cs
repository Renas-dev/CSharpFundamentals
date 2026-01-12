using Helpers;
Console.WriteLine("Hello, user when do u want to sleep?");

string input;
while (true){
    Console.WriteLine("Enter 1 to see ur current best times to go to bed, 2 to choose when to go to bed, 3 to choose when to wake up");
    input = Console.ReadLine();
    
if (input == "1")
{
    SleepNowCalculations.SleepNowCalculation();
}
if (input == "2")
{
    Console.WriteLine("Enter your desired time to wake up at:");
    string userTime = Console.ReadLine();
    WakeUpAtCalculations.WakeUp(userTime);
}
if (input == "3")
{
    Console.WriteLine("Enter your desired time, when u go to bed");
    string userTime = Console.ReadLine();
    SleepAtCalculations.SleepAt(userTime);
} else
{
    Console.WriteLine("please type in either 1, 2 or 3");
}
}
