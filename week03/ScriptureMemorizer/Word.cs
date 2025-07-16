public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Public read-only property for hidden state
    public bool IsHidden => _isHidden;

    // Hide the word by setting _isHidden to true
    public void Hide()
    {
        _isHidden = true;
    }

    // Show the word (not required, but good encapsulation)
    public void Show()
    {
        _isHidden = false;
    }

    // Return underscores if hidden, else the actual word text
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}
