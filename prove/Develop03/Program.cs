using System;
class Program
{
    static void Main(string[] args)
    {
        // I add different scriptures to memorize randomly and let the user practice with larger scriptures and not just one, so the scriptures can be updated and add more or change the scriptures only modifying this ScriptureTask section.
        ScriptureTasks task = new ScriptureTasks();

        task.AddScripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        task.AddScripture(new Reference("Mosiah", 2, 41), "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.");
        task.AddScripture(new Reference("Helaman", 5, 12), "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
        task.AddScripture(new Reference("Isaiah", 1, 18), "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool.");
        task.AddScripture(new Reference("John", 1, 1), "In the beginning was the Word, and the Word was with God, and the Word was God.");

        while (true)
        {
            Console.Clear();
            Scripture scripture = task.RandomScriture();

            if (scripture != null)
            {
                bool memorized = false;

                while (!scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.RenderScripture());

                    Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        return;

                    scripture.HideRandom();

                    if (scripture.IsCompletelyHidden())
                    {
                        memorized = true;
                        break;
                    }
                }

                if (memorized)
                {
                    Console.Clear();
                    Console.WriteLine("Good Job! You memorized the whole scripture!");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("The scripture library is empty. Add scriptures or load them from files.");
                Console.WriteLine();
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                return;
            }
        }
    }
}