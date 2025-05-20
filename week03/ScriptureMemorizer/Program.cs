using System;

// In order to show creativity, I implemented a Library class which contains a library of scriptures and will randomly choose one at the start of the program
// for the user to memorise.  The list of scriptures can be expanded by calling the AddScripture method.

class Program
{
    static void Main(string[] args)
    {
        // What does the program do?  It is a scripture/poem memorizer thingy, that basically takes some passage of text and over time obscures random words.
        // User Inputs: Basically just the one of either press ENTER or type QUIT.
        // Output: The partially/fully obscured passage of text, and a prompt to continue.
        // How does it end?  Writing QUIT or EXIT, or all of the words are now obscured.

        //Classes: Scripture (keeps track of the words and reference, can display the words and hide them.), 
        // Reference (Book, Chapter, Verses information), Word (Keeps track of the word, and probably a bool of shown/hidden).

        // Class Methods and Attributes:
        // Scripture [HideRandomWords(numtohide), GetText(), IsTotallyHidden()] - [_reference, _listOfWords]
        // Word [Hide(), Show(), IsHidden(), GetText()] - [_text, _hidden]
        // Reference [Constructor(), GetText()] - [_book, _chapter, _startVerse, _endVerse]

        // I'm just using 3 scriptures in my library because I'm a bit lazy.
        Library myLibrary = new Library();
        myLibrary.AddScripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy.");
        myLibrary.AddScripture(new Reference("Moroni", 10, 4, 5), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.");
        myLibrary.AddScripture(new Reference("Alma", 13, 21), "And now, as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");

        Scripture myScripture = myLibrary.GetRandomScripture();

        //Main loop
        while (!myScripture.IsTotallyHidden())
        {
            Console.WriteLine(myScripture.GetText());
            Console.WriteLine("Press enter or type 'quit' to finish.");
            string input = Console.ReadLine();
            if (input == "quit" || input == "Quit")
                break;
            myScripture.HideRandomWords(3);
            Console.Clear();
        }

        // Lets write the blank text too when it goes all blank
        Console.WriteLine(myScripture.GetText());
        Console.WriteLine("Goodbye!");
    }
}