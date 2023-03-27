using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox.HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Введите предложение: ");
          SplitText();
        }
         static string[] SplitText()
         {
            string[] splitSentence = Console.ReadLine().Split(' ');
            OutputText(splitSentence);
            return splitSentence;
         }

        static void OutputText(string[] splitSentence)
        {
         for (int i = 0; i < splitSentence.Length; i++)
            {
                Console.WriteLine(splitSentence[i]);
            }
        }
    }
}
