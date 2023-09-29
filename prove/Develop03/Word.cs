public class Word
{
    private string _text;
    private bool _isVisible = true;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isVisible = false;
    }

    public void Show()
    {
        _isVisible = true;
    }

    public bool IsVisisble()
    {
        return _isVisible;
    }

    public string GetDisplayText()
    {
        if(_isVisible)
        {
            return _text;
        }
        else
        {
            int numBlanks = _text.Length;
            string blanks = "";
            int i = 0;
            while(i != numBlanks)
            {
                blanks = blanks +"_";
                i = i + 1;
            }
            return blanks;
        }
    }
}