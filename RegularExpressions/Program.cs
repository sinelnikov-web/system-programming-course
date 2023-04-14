using System.Text.RegularExpressions;

namespace RegularExpressions;
class Program
{
    static void Main()
    {
        // Домашнее задание
        Regex regex = new Regex(@"(?<=^|\s)\S+(?=$|\s)");
        string text = File.ReadAllText("TextFile.txt");
        string[] sentences = text.Split(". ");
        int[] wordsCountBySentence = sentences.Select(sentence => regex.Matches(sentence).ToArray().Length).ToArray();
        Console.WriteLine(String.Join(" ", wordsCountBySentence));
        Console.WriteLine("Введите кол-во слов: ");
        int wordsCount = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < sentences.Length; i++)
        {
            if (wordsCountBySentence[i] == wordsCount)
            {
                Console.WriteLine(sentences[i]);
            }
        }


        // Индивидуальное задание
        DigitReplacer replacer = new DigitReplacer();
        text = File.ReadAllText("TextWithDigits.txt");
        string newText = replacer.replace(text);
        Console.WriteLine("Изначальный текст:\n");
        Console.WriteLine(text);
        Console.WriteLine("Изменённый текст:\n");
        Console.WriteLine(newText);
        Console.ReadKey();
    }
}