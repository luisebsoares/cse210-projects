using System;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new List<(Reference, string)>
        {
            (new Reference("Romans", 5, 3, 5), "We glory in tribulations also: knowing that tribulation worketh patience; And patience, experience; and experience, hope."),
            (new Reference("Doctrine and Covenants", 101, 38), "And seek the face of the Lord always, that in patience ye may possess your souls, and ye shall have eternal life."),
            (new Reference("Alma", 26, 27), "Now when our hearts were depressed, and we were about to turn back, behold, the Lord comforted us."),
            (new Reference("Moroni", 7, 3, 4), "By their works ye shall know them; for if their works be good, then they are good also."),
            (new Reference("Doctrine and Covenants", 58, 42, 43), "Behold, he who has repented of his sins, the same is forgiven, and I, the Lord, remember them no more."),
            (new Reference("2 Peter", 1, 2), "Grace and peace be multiplied unto you through the knowledge of God, and of Jesus our Lord."),
            (new Reference("Mosiah", 26, 29, 30), "As often as my people repent will I forgive them their trespasses against me."),
            (new Reference("Moroni", 6, 8), "But as oft as they repented and sought forgiveness, with real intent, they were forgiven."),
            (new Reference("Moroni", 7, 45), "Charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil."),
            (new Reference("Alma", 57, 26), "And now, their preservation was astonishing to our whole army, yea, that they should be spared while there was a thousand of our brethren who were slain.")
        };

        Random rand = new Random();
        int index = rand.Next(scriptures.Count);
        var selected = scriptures[index];
        Scripture scripture = new Scripture(selected.Item1, selected.Item2);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (!scripture.AllWordsHidden())
            {
                scripture.HideRandomWords();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ended.");
                break;
            }
        }
    }
}