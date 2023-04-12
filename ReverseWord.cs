using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    class Program
    {
        static int ReversePairsCount(List<string> words)
        {
           //I reverse each word for compare with other items of list
            int numberOfPairs = 0;
            for(int i=0; i<words.Count-1;i++)
            {
                string revWord = ReverseWord(words[i]);
                for (int j=i+1;j<words.Count;j++)
                {        
                   if ( revWord == words[j])
                    {
                        numberOfPairs++;
                    }
		//I remove one of similar words  
                   else if(words[i]==words[j])
                    {
                        words.Remove(words[j]);
                    }
                }
            }


            return numberOfPairs;
        }

//method which help I reverse words 
        static string ReverseWord(string s)
        {
            
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        static void Main(string[] args)
        {

            List<string> words = new List<string>() { "hi", "hello", "ih", "hi", "stop","olleh","pots","can" };

          
            Console.WriteLine("Number of pairs = " + ReversePairsCount(words));

           

            Console.Read();

        }
    }
}
