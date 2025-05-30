using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this in mind in the future?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"\n{_prompts[new Random().Next(_prompts.Count)]}\n");
    }

    public void DisplayQuestions()
    {
        int elapsed = 0;
        Random rand = new Random();
        while (elapsed < _duration)
        {
            Console.WriteLine($"> {_questions[rand.Next(_questions.Count)]}");
            ShowSpinner(5);
            elapsed += 5;
        }
    }
}