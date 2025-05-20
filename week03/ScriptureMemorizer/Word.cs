public class Word
{
    // Word [Hide(), Show(), IsHidden(), GetText()] - [_text, _hidden]
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool isHidden()
    {
        return _hidden;
    }

    public string getText()
    {
        if (isHidden())
        {
            string hiddenText = new string('_', _text.Length);
            return hiddenText;
        }
        else
            return _text;
    }
    
}