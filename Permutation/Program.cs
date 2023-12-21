//Given 2 strings, write a method to decide if one is a permutation of the other.
// Explanation, if 2 words have the same letters in same quantity, its an permutation bcs its an anagram.
bool IsPerumted(string word1, string word2)
{
    var word1List = CountNumbersOfLetters(word1);

    var word2List = CountNumbersOfLetters(word2);

    var verifyWord = 0;

    if (word1List.Count != word2List.Count)
        return false;
    else
    {
        foreach (var word in word1List)
        {
            for (int i = 0; i < word2List.Count; i++)
            {
                if (word.Equals(word2List[i]))
                    verifyWord++;
            }

            Console.WriteLine($"{word.Letter}, {word.NbLetters}");
        }

        if (verifyWord == word1List.Count)
            return true;
        else return false;
    }
}

List<Word> CountNumbersOfLetters(string word)
{
    var numbers = new List<Word>();

    foreach(var letter in word)
    {
        if (!numbers.Any(x => x.Letter == letter.ToString()))
        {
            numbers.Add(new Word(letter.ToString(), 1));
        }
        else
        {
            var nb = numbers.Where(x => x.Letter == letter.ToString()).Single();

            nb.NbLetters++;
        }
    }

    return numbers;
}

Console.WriteLine(IsPerumted("eell", "llee"));
public class Word
{
    public string Letter { get; set; }
    public int NbLetters { get; set; }

    public Word(string letter, int nbLetters)
    {
        Letter = letter;
        NbLetters = nbLetters;
    }

    public override bool Equals(object? obj)
    {
        Word p = (Word)obj;

        return (Letter == p.Letter) && (NbLetters == p.NbLetters);
    }
}
