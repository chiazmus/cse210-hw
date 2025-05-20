public class Library
{
    private List<Scripture> _scriptures;
    private Random _randomNumberGenerator;

    public Library()
    {
        _scriptures = new List<Scripture>();
        _randomNumberGenerator = new Random();
    }

    public void AddScripture(Reference reference, string text)
    {
        Scripture newScripture = new Scripture(reference, text);
        _scriptures.Add(newScripture);
    }
    

    public Scripture GetRandomScripture()
    {
        return _scriptures[_randomNumberGenerator.Next(_scriptures.Count)];
    }
}