using System.IO;
public class PromptGenerator
{
    string[] prompts = {
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What is something cool that I saw today?", 
        "What is something new that I learned today?", 
        "What was a challenge that I overcame today?"
    };
    Random random = new Random();
    public string GetRandomPrompt()
    {
        return prompts[random.Next(prompts.Length)];
    }
}