using System;
using System.Text.RegularExpressions;

namespace yetgenJumpAkbankBackendEgitimProgramı2
{
    class Program
    {
        private const string Pattern = @"(?<=[.,;?!])";

        static string TextControl(string text)
        {
            string newText = Regex.Replace(text, Pattern, " ");
            string[] words = newText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (i == 0 || words[i - 1].EndsWith(".") || words[i - 1].EndsWith("!") || words[i - 1].EndsWith("?"))
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
            }

            string resultNewText = string.Join(" ", words);
            return resultNewText;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text");
            string enterText = Convert.ToString(Console.ReadLine());
            string result = TextControl(enterText);
            Console.WriteLine("Result:");
            Console.WriteLine(result);
        }
    }
}
