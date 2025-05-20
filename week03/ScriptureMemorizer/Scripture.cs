public class Scripture
{
    // Scripture [HideRandomWords(numtohide), GetText(), IsTotallyHidden()] - [_reference, _listOfWords, _randomNumberGenerator]
    private Reference _reference;
    private List<Word> _listOfWords;

    private Random _randomNumberGenerator;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _listOfWords = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _listOfWords.Add(new Word(word));
        }

        _randomNumberGenerator = new Random();

    }

    public void HideRandomWords(int numToHide)
    {
        // JS taught me that anonymous functions are cool.  I love them now.
        List<Word> unhiddenWords = _listOfWords.Where(unhiddenWord => !unhiddenWord.isHidden()).OrderBy(unhiddenWord => _randomNumberGenerator.Next()).ToList();

        for (int i = 0; i < numToHide; ++i) //Lowkey I only do the ++i thing cuz my dad does it, and I wanna be like him.  He's cool too.
        {
            if (unhiddenWords.Count <= 0)
                break;

            unhiddenWords[unhiddenWords.Count - 1].Hide();
            unhiddenWords.RemoveAt(unhiddenWords.Count - 1);
        }
    }

    public string GetText()
    {
        string returnString = $"{_reference.GetText()} - " + string.Join(" ",_listOfWords.Select(word => word.getText()).ToList()); 
        return returnString;
    }

    public bool IsTotallyHidden()
    {
        foreach (Word word in _listOfWords)
        {
            if (!word.isHidden()) 
                return false;
        }

        return true;
    }

}