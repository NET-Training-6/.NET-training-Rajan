class Paragraph1
{
    string story = @"A Boy was given permission to put his hand into a, \\
        pitcher to get some filberts. But he took such a great fistful \\
        that he could not draw his hand out again. There he stood, unwilling \\
        to give up a single filbert and yet unable to get them all out at once. \\
        Vexed and disappointed he began to cry. Another Sentence Here.";
    int noOfSentences = 0;
    int noOfWords = 0;
    int noOfCharacters = 0;

    public Paragraph1()
    {
        CountSentences();
        CountWords();
        CountCharacters();
        GetFrequenciesOfCharacters();

    }
    public void CountSentences()
    {
        string[] sentenceDelimeter = new string[] { ".", "?" };
        var sentences = story.Split(sentenceDelimeter, StringSplitOptions.RemoveEmptyEntries);
        noOfSentences = sentences.Length;
    }

    public void CountWords()
    {
        string[] wordsDelimeter = new string[] { " " };
        var words = story.Split(wordsDelimeter, StringSplitOptions.RemoveEmptyEntries);
        noOfWords = words.Length;
    }

    public void CountCharacters()
    {
        // string[] charactersDelimeter = new string[] { ",", " ", ".", "?", "-", "'" };
        // var characters = story.Split(charactersDelimeter, StringSplitOptions.RemoveEmptyEntries);

        string validCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        foreach (var stringItem in story)
        {
            if (validCharacters.Contains(stringItem))
            {
                //Console.Write(stringItem);
                noOfCharacters++;
            }

        }
    }

    public void GetFrequenciesOfCharacters()
    {
        List<char> uniqueCharacters = new();
        foreach (char character in story)
        {
            if (uniqueCharacters.Contains(character) == false)
            {
                uniqueCharacters.Add(character);
            }
        }
        Console.WriteLine("No Unique Characters : " + uniqueCharacters.Count());

        foreach (var item in uniqueCharacters)
        {
            int noOfCharactersInString = 0;
            foreach (var a in story)
            {
                if (a == item)
                {
                    noOfCharactersInString++;
                }
            }
            string skipCharacters = " \t\n,";
            if (skipCharacters.Contains(item) == false)
            {
                Console.WriteLine($"No of {item} in string : {noOfCharactersInString}");
            }
        }
    }

    public void DisplayParagraphInfo()
    {
        Console.WriteLine($"\n\nNo of Sentences : {noOfSentences}, No of words : {noOfWords}, No of characters : {noOfCharacters}");
    }
}