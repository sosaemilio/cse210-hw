class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _word = new List<Word> {};

   public Scripture(Reference reference, List<string> words)
   {
    this._reference = reference;
    // Converte WordList into a Object Word 
    foreach(string word in words)
    {
        Word aWord = new Word(word);
        _word.Add(aWord);
    }
   }

   public Scripture(Reference reference, List<Word> words)
   {
    this._reference = reference;
    this._word = words;
   }

   public void getScripture()
   {
    string reference = _reference.GetReference();
    List<string> words = new List<string> {};
    foreach(Word aWord in _word)
    {
        string word = aWord.GetWord();
        if (aWord.IsHidden()){
            string underline = "";
            foreach(char letter in word)
            {
                underline += "_";
            }
            words.Add(underline);
        } else {
            words.Add(word);
        }
    }

    Console.Write(reference);
    foreach(string word in words)
    {
        Console.Write($" {word}");
    }
   }

   public void SetScripture(Reference reference, List<Word> words) 
   {
    this._reference = reference;
    this._word = words;
   }

    //Methods
    public void HideRandomWord()
    {
        int listLenght = _word.Count;
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, listLenght - 1);
        string randomWord = _word[randomNumber].GetWord();
        
        // TEST - TO BE REMOVED
        Console.WriteLine(randomWord);
        //
        _word[randomNumber].HideWord();
    }
}