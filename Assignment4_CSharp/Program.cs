using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList words = new ArrayList();
            words.Add("Boat");
            words.Add("House");
            words.Add("Cat");
            words.Add("River"); ;
            words.Add("Cupboard");


            //output the plurals of words
            Console.WriteLine("Plural of the words :");
            foreach (string word in words)
            {
                Console.WriteLine(word + "s");
            }

            //Replace Of 2nd word with it's synonym
            words[1] = "Home";
            Console.WriteLine("\n \nSynonym of word 'House' is : {0}\n", words[1]);

            //apending a new word and print the length of arraylist
            words.Add("Laptop");
            Console.WriteLine("\n \nArray list length after insertion of word 'Laptop' : {0}\n", words.Count);

            //Output the words of having character length seven
            Console.WriteLine("\n \nPrinting Words of Length 7");
            for (int i = 0; i < words.Count; i++)
            {
                string str = (string)words[i];
                if (str.Length == 7)
                {
                    Console.WriteLine(words[i]);
                }
            }

            //output of word on third position
            Console.WriteLine("\n \nWord on 3rd position :{0} ", words[2]);

            //Sorting Of Array In Ascending Order
            Console.WriteLine("\n \nSorted ArrayList :");
            for (int i = 0; i < words.Count; i++)
            {
                words.Sort();
                Console.WriteLine(words[i]);
            }

            //Reverse Of Array
            Console.WriteLine("\n \nReverse Order Of ArrayList :");
            for (int i = words.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }

        }
    }
}
