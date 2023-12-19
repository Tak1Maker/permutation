//Given 2 strings, write a method to decide if one is a permutation of the other.
// Explanation, if 2 words have the same letters in same quantity, its an permutation bcs its an anagram.

bool IsPermuted(string word1, string word2)
{
    //1. 
    bool isPerm = false;
    //2. 
    if (word1.Length != word2.Length)
        isPerm = false;
    else
    {
        var t = 0;
    
        for (int i = 0; i < word1.Length; i++)
        {
            var n = 0;
            for(int l = 0; l < word1.Length; l++)
            {
                if (word1[i] == word2[l] && n <= 1)
                {
                    t++;
                    n++;
                }
            }
        }

        if (t == word1.Length)
            isPerm = true;
    }
    
    return isPerm;
}

Console.WriteLine(IsPermuted("luca","calu"));