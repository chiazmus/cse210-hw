using System;

class Program
{

    //Sorry, I did all the notes and planning here in the program.

    // Notes:
    // What does the program do?  It is a simple journal app that will prompt the user with a prompt, they can write
    // anything, and then save it in a file.  They can also load in other journal files to view them.
    // User inputs: The menu which displays options 1-5 for [write, display, load, save, exit], along with journal entries and file names.
    // Outputs: Journal prompts, journal entries, and the menu.
    // How does the program end?  The user types 5. when at the menu which exits the program.

    // Classes: Menu (although maybe this could just be actuated in the main method instead of a class?  Yeah, I'll just do that.), PromptGenerator, Journal, Entry
    // PromptGenerator: Variables - List<string> prompts; Methods - GeneratePrompt() which returns a random prompt from the list of prompts.  Maybe I'll use prefix-subfixes in the future
    // Journal: Variables - List<Entry> entries; Methods - AddEntry() which adds entries, 
    // DisplayEntries(), which displays all of the journal entries and Save() which saves the journal to a file and Load() which loads the journal from a file.
    // Entry: Variables - string _entry, string _date, string _promptText; Methods - DisplayEntry() which displays the entry.

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
    }
}