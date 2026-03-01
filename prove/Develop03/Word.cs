public class Word
{
    private string _text = "";
    private bool _hidden = false;
    public Word(string text, bool hidden)
    {
        _text = text;
        _hidden = hidden;
    }
    public void Hide()
    {
        
    }
    public void Show()
    {
        
    }
    public bool IsHidden()
    {
        
    }
    public string GetWord()
    {
        return $"{_text}";
    }
}