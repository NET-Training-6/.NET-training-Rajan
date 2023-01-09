class Paragraph
{
    string story = @".NET is a free and open-source, managed computer operating systems. \\ 
    How are you ,my friends and what have you learnt here at infosys.\\
    How are you ,my friends and what have you learnt here at infosys.\\
    It is a cross-platform successor to .NET Framework. The project is primarily developed by Microsoft employees by way of the\\
    NET Foundation, and released under the MIT License.";

    public void COuntSentences()
    {
        var seperators = new char[] {'.', '?'};
        var sentences = story.Split(seperators,StringSplitOptions.RemoveEmptyEntries);
        foreach(var sentence in sentences)
        {
            Console.WriteLine(sentence);
        }

        var noOfSentences = sentences.Length;


        Console.WriteLine("Sentence Counts:" + noOfSentences);
    }
    public void COuntWords()
    {
        var seperators = new char[] {' ', '\t'};
        var words = story.Split(seperators,StringSplitOptions.RemoveEmptyEntries);

        foreach(var word in words)
        {
            var Sabda = word;
            if(word.Contains(','))
            {
               Sabda = Sabda.Replace(",", "");
            }

            Console.WriteLine(Sabda);
            
        }
        var noOfWords = words.Length;
        Console.WriteLine("word Counts:" + noOfWords);
    }

}