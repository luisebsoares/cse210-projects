public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        ShowCountDown(5);
        List<string> items = GetListFromUser();
        Console.WriteLine($"\nYou listed {items.Count} items.");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        string prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}\n");
    }

    public List<string> GetListFromUser()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> list = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            list.Add(Console.ReadLine());
        }
        return list;
    }
}