public class Word
{
    public string text { get; }
    public bool _isHidden { get; private set; }

    public Word(string Text)
    {
        text = Text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public override string ToString()
    {
        return _isHidden ? new string('_', text.Length) : text;
    }
}