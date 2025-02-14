using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Scripture
{
    private List<Word> _displayWords;
    public bool _allHidden = false;

    public Scripture(string scripture)
    {
        ListMaker(scripture);
    }

    private void ListMaker(string scripture)
    {
        List<Word> _scriptureWords = new List<Word>();

        MatchCollection matches = Regex.Matches(scripture, @"\w+[\p{P}]?");
        foreach (Match match in matches)
        {
            _scriptureWords.Add(new Word(match.Value));
        }

        _displayWords = _scriptureWords;
    }

    private void HiddenChecker()
    {
        
    }

    public void Display()
    {
        string _displayWord;
        foreach(Word current in _displayWords)
        {
            _displayWord = current.GetWord();
            Console.Write($"{_displayWord} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    
    public void RemoveWord()
    {
        Random random = new Random();
        for (int i = 0; i < 3; i++)
        {
            int index = random.Next(_displayWords.Count);
            _displayWords[index].HideWord();
        }
    }
}