public class Entry{
    // Entry: Variables - string _entry, string _date, string _promptText;
    // Methods - DisplayEntry() which displays the entry
    public string _entry;
    public string _date = DateTime.Now.ToShortDateString();
    public string _promptText;
    public string _location;
    public string _mood;


    public void DisplayEntry(){
        Console.WriteLine($"Date: {_date} - Location: {_location} - Prompt: {_promptText}\nMood: {_mood}\n{_entry}\n");
    }

}