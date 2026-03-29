string word = "successfully";

Dictionary<char, int> count = new Dictionary<char, int>();
foreach (char str in word)
{
    if (count.ContainsKey(str))
    {
        count[str]++;
    }
    else
    {
        count.Add(str, 1);
    }
}

Console.WriteLine($"the word is :{word}");
foreach (var item in count)
{
    Console.WriteLine($"char:{item.Key}, count:{item.Value}");
}