using System;

public class Reference
{
    private string _book;
    private int _chapiter;
    private int _verse;
    private int _endVerse;


    public Reference(string book, int chapiter, int verse)
    {
        _book = book;
        _chapiter = chapiter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapiter, int startVerse, int endVerse)
    {
        _book = book;
        _chapiter = chapiter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayTextString()

    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapiter}: {_verse}";
        }
        else
        {
            return $"{_book} {_chapiter}: {_verse}-{_endVerse}";
        }

    }
}