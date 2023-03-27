using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox.HomeWork5.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string inputPhrase = Console.ReadLine();
            SplitText(inputPhrase);
        }
        static string[] SplitText(string inputPhrase)
        {
            string[] splitSentence = inputPhrase.Split(' ');
            ReverseSentence(splitSentence);
            return splitSentence;
        }
        static void ReverseSentence (string[] splitSentence)
        {
            for (int i = splitSentence.Length-1; i >= 0; i--)
            {
                Console.Write(splitSentence[i]+" ");

            }
        }
    }
}
