string[] words = Console.ReadLine().Split(" ");
Dictionary<string, int> wordsCount = new();

foreach (string word in words)
{
    string caseInsensitivesWord = word.ToLower();
    if (wordsCount.ContainsKey(caseInsensitivesWord))
    {
        wordsCount[caseInsensitivesWord]++;
    }
    else
    {
        wordsCount.Add(caseInsensitivesWord, 1);
    }
}

foreach (KeyValuePair<string, int> pair in wordsCount)
{
    if (pair.Value % 2 != 0)
    {
        Console.Write ($"{pair.Key} ");
    }
    
}
