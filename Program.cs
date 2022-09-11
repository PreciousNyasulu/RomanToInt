// See https://aka.ms/new-console-template for more information

int RomanToInt(string s)
{
    int value = 0;
    List<char> letters = new List<char>();
    var stuff = new Dictionary<string, int> { { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 }, { "C", 100 }, { "D", 500 }, { "M", 1000 } };
    foreach (char c in s.ToUpper())
    {
        letters.Add(c);
    }

    for (int i = 0; i < letters.Count; i++)
    {
        value += stuff[letters[i].ToString()];
    }
    
    return value;
}

Console.WriteLine(RomanToInt("LVIII"));


