using System.Text.RegularExpressions;

namespace RegularExpressions;
class DigitReplacer
{
    private Dictionary<string, string> numbers = new Dictionary<string, string>()
    {
        { "0", "Ноль" },
        { "1", "Один" },
        { "2", "Два" },
        { "3", "Три" },
        { "4", "Четыре" },
        { "5", "Пять" },
        { "6", "Шесть" },
        { "7", "Семь" },
        { "8", "Восемь" },
        { "9", "Девять" },
    };
    public string replace(string text)
    {
        Regex regex = new Regex(@"\d");
        string newText = regex.Replace(text, delegate (Match match)
        {
            string v = match.ToString();
            return this.numbers[v];
        });
        return newText;
    }
}

