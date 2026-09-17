using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _refence;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _refence = reference;
        _words = new List<Word>();

        string[] splitText = text.Split(' ');

        foreach (string wordString in splitText)
        {
            _words.Add(new Word(wordString));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayTextString()
    {
        string textDisplay = "";
        foreach (Word word in _words)
        {
            textDisplay += word.GetDisplayTextString() + " ";
        }
        return $"{_refence.GetDisplayTextString()} {textDisplay.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}
