using System;
using System.Collections.Generic;

namespace DesignQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //QueueTestCase();
            //StringCompressorTestCase();
            //AnagramTestCase();
            //FindDuplicatesTestCase();
        }

        private static void FindDuplicatesTestCase()
        {
            int[] array = { 1, 2, 3, 1, 3, 4, 5, 7, 4 };
            List<int> dups = FindAllDuplicates.findDups(array);
            foreach (var dup in dups)
            {
                Console.WriteLine(dup);
            }

            Console.ReadLine();
        }

        private static void AnagramTestCase()
        {
            Anagram a = new Anagram();
            Console.WriteLine(a.isAnagram("anand", "nanda"));
            Console.WriteLine(a.isAnagram("try", "ryt"));
            Console.WriteLine(a.isAnagram("bandana", "banana"));
            Console.ReadLine();
        }

        private static void StringCompressorTestCase()
        {
            StringCompressor sc = new StringCompressor();
            Console.WriteLine(sc.compress("aaa"));
            Console.WriteLine(sc.compress("aaabbbbddeeeee"));
            Console.ReadLine();
        }

        private static void QueueTestCase()
        {
            QueueAsStack q = new QueueAsStack();
            q.enqueue(1);
            q.enqueue(2);
            q.enqueue(3);

            Console.WriteLine(q.dequeue());
            q.enqueue(4);
            q.enqueue(5);

            Console.WriteLine("Peek: " + q.front());

            Console.WriteLine(q.dequeue());
            Console.WriteLine(q.dequeue());
            Console.WriteLine("Peek: " + q.front());

            Console.WriteLine(q.dequeue());
            Console.WriteLine(q.dequeue());

            Console.ReadLine();
        }
    }
}
