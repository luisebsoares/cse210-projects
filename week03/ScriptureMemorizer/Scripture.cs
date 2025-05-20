using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] parts = text.Split(' ');

        foreach (string word in parts)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        Random rand = new Random();
        int wordsToHide = 3;


        List<int> visibleIndexes = _words
            .Select((word, index) => new { word, index })
            .Where(w => !w.word.IsHidden())
            .Select(w => w.index)
            .ToList();

        int count = Math.Min(wordsToHide, visibleIndexes.Count);
        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(visibleIndexes.Count);
            _words[visibleIndexes[index]].Hide();
            visibleIndexes.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }

        return display.Trim();
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
