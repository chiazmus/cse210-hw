using System.IO;
using System.Text.Json;

public class Journal{
    // Journal: Variables - List<Entry> entries; 
    // Methods - AddEntry() which adds entries, 
    // DisplayEntries(), which displays all of the journal entries and Save() which saves the journal to a file and Load() which loads the journal from a file.
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry newEntry){
        entries.Add(newEntry);
    }

    public void DisplayEntries(){
        foreach (Entry entry in entries){
            entry.DisplayEntry();
        }
    }

    public void Save(string fileName){
        using (StreamWriter output = new StreamWriter(fileName)) {
            foreach (Entry entry in entries) {
                output.WriteLine($"{entry._entry};{entry._date};{entry._promptText};{entry._location};{entry._mood}");
            }
        }
    }

    public void Load(string fileName){
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines){
            string[] parts = line.Split(';');
            
            Entry newEntry = new Entry();

            newEntry._entry = parts[0];
            newEntry._date = parts[1];
            newEntry._promptText = parts[2];
            newEntry._location = parts[3];
            newEntry._mood = parts[4];

            AddEntry(newEntry);
        }
    }



}