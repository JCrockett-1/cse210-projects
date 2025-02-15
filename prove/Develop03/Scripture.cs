using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Scripture
{
    private List<Word> _displayWords;
    public bool _allHidden;

    public Scripture(string scripture)
    {
        ListMaker(scripture);
    }

    private void ListMaker(string scripture)
    {
        List<Word> _scriptureWords = new List<Word>();

        string[] words = scripture.Split(" ");
        foreach (string word in words)
        {
            _scriptureWords.Add(new Word(word));
        }

        _displayWords = _scriptureWords;
    }

    private void HiddenChecker()
    {
        foreach (Word word in _displayWords)
        {
            if (word._hidden == false)
            {
                _allHidden = false;
                break;
            }
            else
            {
                _allHidden = true;
            }
        }
    }

    public void Display()
    {
        string _displayWord;
        foreach(Word current in _displayWords)
        {
            _displayWord = current.GetWord();
            if (current._hidden == false)
            {
                Console.Write(_displayWord + " ");
            }
            else
            {
                string hiddenName = "";

                foreach (char letter in _displayWord)
                {
                    hiddenName = hiddenName + "_";
                }    

                Console.Write(hiddenName + " ");
            }
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    
    public void RemoveWord()
    {
        Random random = new Random();
        int index = random.Next(_displayWords.Count);
        while (_displayWords[index]._hidden)
        {
            index = random.Next(_displayWords.Count);
        }
        _displayWords[index].HideWord();
        HiddenChecker();
    }
}