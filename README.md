# RomanToInt
Basic program that take roman numerals as input and converts into an integer. This is a challenge from <a href='https://leetcode.com/problems/roman-to-integer/'>leetcode.com</a> where a function is given an arguement(a roman numeral) and it has to be converted to an integer, the function has to return the calculated value. 


Roman numeral string arguement.
```c#
int RomanToInt(string RomanNumeral);
```



A Dictionary containing the roman numeral values is kept as reference when calculating the given value.
```c#
var stuff = new Dictionary<string, int> { { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 }, { "C", 100 }, { "D", 500 }, { "M", 1000 } };
```


A list is created where all the indivual letters from the given value will be kept.
The program will then loop through the string value and add each letter in the created list.
```c#
List<char> letters = new List<char>();
foreach (char c in s.ToUpper())
{
    letters.Add(c);
}
```


The program will then run a loop that checks each letter from the list and matches it agains the values in the <strong>Roman Numeral</strong> dictionary. When a match has been found, a variable named value is incremented by the value of the <strong>Roman Numeral</strong> and then returned.
```c#
int value;
for (int i = 0; i < letters.Count; i++)
    {
        value += stuff[letters[i].ToString()];
    }
rerurn value;
```

Example: If the value:"vi" is given as an arguement the result will be 6
```c#
int RomanToInt(string s)
{
    
    List<char> letters = new List<char>();
    
    var RomanNumeralValues = new Dictionary<string, int> { { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 }, { "C", 100 }, { "D", 500 }, { "M", 1000 } };
    
    foreach (char c in s.ToUpper())
    {
        letters.Add(c);
    }
    
    int value;
    for (int i = 0; i < letters.Count; i++)
    {
        value += RomanNumeralValues[letters[i].ToString()];
    }


    return value;
}

Console.WriteLine("The integer value is: " RomanToInt("vi"));
//The integer value is: 6
```
