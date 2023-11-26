int[] num = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
SortedDictionary<int, int> numFreq = new SortedDictionary<int, int>();

foreach (int item in num)
{
    if (numFreq.ContainsKey(item))
    {
        numFreq[item]++;
    }
    else
    {
        numFreq.Add(item, 1);
        //numFreq[item] = 1;
    }
}

foreach (KeyValuePair<int, int> pair in numFreq)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
 