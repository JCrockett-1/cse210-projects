public class Word
{
    private string _word = "";
    public bool _hidden = false;

    public Word(string word)
    {
        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }

    public void HideWord()
    {       
        string hiddenName = "";

        foreach (char letter in _word)
        {
            hiddenName = hiddenName + "_";
        }    

        _word = hiddenName;
        _hidden = true;
    }
}