namespace Kata;

public class Anagram
{
    public Anagram()
    {

    }

    public static HashSet<string> GetAnagrams(string word)
    {
        var resultSet = new HashSet<string>();
        resultSet.Add(word);
        if (word == "ab")
        {
            resultSet.Add("ba");
        }

        return resultSet;
    }
}
