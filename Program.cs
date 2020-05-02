using System;

namespace wordTwister
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Geben Sie das Wort ein: "); 
            string str = Console.ReadLine(); 
            Console.WriteLine(wordMixing(str)); 
        }

        static string wordMixing(string startingWord) {
            Random random = new Random();

            char[] startingArray = startingWord.ToCharArray(0, startingWord.Length); 
            for (int i = 1; i < startingArray.Length - 1; i++) {                     
                for (int j = i + 1; j < startingArray.Length - 1; j++) {
                    if (random.Next(10) <= random.Next(10)) {                        
                        char temp = startingArray[i];
                        startingArray[i] = startingArray[j];
                        startingArray[j] = temp;
                    }
                }
            }
            return new string(startingArray);
        }
    }
}
