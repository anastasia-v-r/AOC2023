namespace AOC2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BaseDay> baseDays = new List<BaseDay>();
            baseDays.Add(new Day1());

            do
            {
                Console.WriteLine("Welcome to the Program list for AOC2023!\n"
                + "So far there have been " + baseDays.Count.ToString() + " days written in.\n"
                + "Select which day you would like to view!\n");

                string userInput = Console.ReadLine();

                Console.Clear();
                baseDays[Int32.Parse(userInput)].Run();

                Console.WriteLine("Would you like to run another sub-program? [y/n]");

                userInput = Console.ReadLine();

                if (userInput != "y")
                    return;
                Console.Clear();
            } while (true);
        }
    }
}
