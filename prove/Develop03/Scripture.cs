public class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private Random _random;

    public Scripture(Reference reference, List<Word> words, Random random)
    {
        _words = words;
        _reference = reference;
        _random = random;
    }
    public void HideRandom()
    {
        
    }
    public string GetScripture()
    {
        return $""
    }
    public bool IsCompletelyHidden()
    {
        
    }
}