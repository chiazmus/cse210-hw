using System.IO;

public class PromptGenerator{
    // PromptGenerator: Variables - List<string> prompts; 
    // Methods - GeneratePrompt() which returns a random prompt from the list of prompts.  LoadPrompts, which loads a list of prompts to use from a file.
   
    public List<string> prompts = new List<string>();
    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    public void LoadPrompts(string fileName){
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines){
            prompts.Add(line);
        }
    }
}