// See https://aka.ms/new-console-template for more information

int RomanToInt(string s)
{
    int value = 0;
    List<char> letters = new List<char>();
    List<int> numbers = new List<int>();
    var stuff = new Dictionary<string, int> { { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 }, { "C", 100 }, { "D", 500 }, { "M", 1000 } };
    foreach (char c in s.ToUpper())
    {
        letters.Add(c);
    }

    for (int i = 0; i < letters.Count; i++)
    {
        value += stuff[letters[i].ToString()];
        numbers.Add(stuff[letters[i].ToString()]);
    }


    // for (int i = 0; i < numbers.Count; i++)
    // {
    //     Console.WriteLine(numbers[i]+"-"+numbers.Count);
    //     if (numbers[i] < numbers[numbers.Count - (numbers.Count - i)])
    //     {
    //         value = numbers[i++] - numbers[i];
    //     }
    //     else /*if (numbers[i] > numbers[i++]) */
    //     {
    //         value = numbers[i] + numbers[i++];
    //     }
    // }

    return value;
}

Console.WriteLine(RomanToInt("vi"));


