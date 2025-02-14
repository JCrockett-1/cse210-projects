public class Reference
{
    private string _book;
    private int _chapter;
    private int _startingVerse;
    private int _endingVerse = 0;

    public Reference(string book, int chapter, int startingVerse)
    {
        _book = book;
        _chapter = chapter;
        _startingVerse = startingVerse;
    }
    public Reference(string book, int chapter, int startingVerse, int endingVerse)
    {
        _book = book;
        _chapter = chapter;
        _startingVerse = startingVerse;
        _endingVerse = endingVerse;
    }

    public void Display()
    {
        if (_endingVerse == 0)
        {
            Console.Write($"{_book} {_chapter}:{_startingVerse} ");
        }
        else
        {
            Console.Write($"{_book} {_chapter}:{_startingVerse}-{_endingVerse} ");
        }
    }
}