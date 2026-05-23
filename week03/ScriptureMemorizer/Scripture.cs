class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string part in words.Split())
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int count)
    {
        // Naive approach, probably good enough for this program
        Random randomGenerator = new Random();
        while (count > 0)
        {
            List<Word> shownWords = new List<Word>();
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    shownWords.Add(word);
                }
            }
            if (shownWords.Count() <= 0)
            {
                break;
            }
            int toHide = randomGenerator.Next(0, shownWords.Count);
            shownWords[toHide].Hide();
            count--;
        }
    }

    public string GetDisplayText()
    {
        List<string> words = new List<string>();
        foreach (Word word in _words)
        {
            words.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()}\n{String.Join(" ", words)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() != true)
            {
                return false;
            }
        }
        return true;
    }
}