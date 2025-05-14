public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What is something I learned about myself today?",
    "What challenge did I face today, and how did I handle it?",
    "What am I most grateful for today?",
    "In what moment today did I feel most at peace?",
    "What fear have I overcome recently, and how did it change me?",
    "If I could give my younger self one piece of advice, what would it be?",
    "What am I currently doing that brings me closer to the life I want?",
    "What’s a lesson I had to learn the hard way, but am now grateful for?",
    "If I were a character in a movie today, what kind of scene would I be in?",
    "If I could invent a new holiday, what would it celebrate and how would we party?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
