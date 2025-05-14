using System;

// IN order to demonstrate creativity, I made it so it pulls the prompts from a file, to make it easier to generate prompts
// And I also made it so it asks for your mood and location and saves those in addition to dates and prompts and entries.
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

        Console.WriteLine("Welcome to the Journal Program!");

        PromptGenerator promptGen = new PromptGenerator();
        promptGen.LoadPrompts("prompts.txt");
        Journal journal = new Journal();

        // Alright lets do all the menu stuff here, now that the journal and promptgenerator are initiated.
        bool continueProgram = true;

        while (continueProgram){

            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            
            if (choice == "1"){
                Entry newEntry = new Entry();
                newEntry._promptText = promptGen.GeneratePrompt();
                Console.WriteLine(newEntry._promptText);
                Console.Write("Location: ");
                newEntry._location = Console.ReadLine();
                Console.Write("Mood: ");
                newEntry._mood = Console.ReadLine();
                Console.Write("> ");
                newEntry._entry = Console.ReadLine();
                journal.AddEntry(newEntry);
            } else if (choice == "2") {
                journal.DisplayEntries();
            } else if (choice == "3"){
                journal.Load("journal.txt");
                Console.WriteLine("Journal Loaded.");
            } else if (choice == "4"){
                journal.Save("journal.txt");
                Console.WriteLine("Journal Saved.");
            } else if (choice == "5") {
                continueProgram = false;
                Console.WriteLine("Good Bye.");
            } else {
                Console.WriteLine("That is not a valid choice.  Please try again.");
            }

        }

    }
}