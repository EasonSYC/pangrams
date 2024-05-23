const string _isPangramText = "You have entered a pangram which contains every letter in the alphabet at least once.";
const string _notPangramText = "Your sentence is not a pangram as it does not contain the following letters: ";
const string _promptText = "Please enter a sentence: ";

string input = string.Empty;
while (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine(_promptText);
    input = Console.ReadLine() ?? string.Empty;
}

input = input.ToLower();
bool[] letters = new bool[26];

foreach (char cc in input)
{
    if (cc >= 'a' && cc <= 'z')
    {
        letters[cc - 'a'] = true;
    }
}

List<string> notIncluded = [];

for (int i = 0; i < 26; ++i)
{
    if (!letters[i])
    {
        notIncluded.Add($"{(char)('a' + i)}");
    }
}

if (notIncluded.Count != 0)
{
    Console.WriteLine(_notPangramText + string.Join(", ", notIncluded));
}
else
{
    Console.WriteLine(_isPangramText);
}