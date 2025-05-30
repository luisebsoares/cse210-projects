using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            if (choice == "4") break;

            switch (choice)
            {
                case "1": new BreathingActivity().Run(); break;
                case "2": new ListingActivity().Run(); break;
                case "3": new ReflectingActivity().Run(); break;
            }
        }
    }
}