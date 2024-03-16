using System.Runtime.CompilerServices;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            Word wordObject = new Word(word);
            _words.Add(wordObject);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int countdown = numberToHide;
        int iterations = 0;

        // I believe this can be optimized, because when most words are hidden, it repeats a lot of them on the
        // loop searching for the remaining ones.
        // I suppose that by using a temporary list that contains only the non hidden words this can be solved,
        // but I didn't find a way to make it work
        while (countdown > 0)
        {
            iterations += 1;
            if (IsCompletelyHidden())
            {
                break;
            }

            Word randWord = _words[random.Next(0, _words.Count)];
            if (randWord.IsHidden())
            {
                continue;
            }
            else
            {
                randWord.Hide();
                countdown -= 1;
            }
        }
    }

    public string GetDisplayText()
    {
        string verseText = "";
        for (int i = 0; i < _words.Count; i++)
        {
            verseText += _words[i].GetDisplayText();

            if (i != _words.Count - 1)
            {
                verseText += " ";
            }
        }

        string fullText = $"{_reference.GetDisplayText()} {verseText}";
        return fullText;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(x => x.IsHidden());
    }
}