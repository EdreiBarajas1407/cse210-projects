using System;
using System.Collections.Generic;

class PromptGenerator
{
  public static string GetRandomPrompt()
  {
    List<string> prompts = new List<string>
        {
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was a small act of kindness I witnessed or experienced today?",
            "What gave you stress today?",
            "What is something selfless you did for someone else today?",
            "How can you make tomorrow even better than today?",
            "Reflect on a challenge or obstacle you faced today and how you overcame it.",
            "Write about something new you learned today.",
        };

    Random random = new Random();
    int index = random.Next(prompts.Count);
    return prompts[index];
  }
}