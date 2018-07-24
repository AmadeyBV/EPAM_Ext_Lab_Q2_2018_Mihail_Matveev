using System;

namespace Subtask1
{
    class ArrayStrings
    {
        const string generateArrayMessage = "Unsorted array:";
        const string sortedArrayMessage = "Sorted array:";

        string[] strings;
        Random random = new Random();

        public ArrayStrings()
        {
            GenerateArray();
            OutputArray(generateArrayMessage);
        }

        void OutputArray(string message)
        {
            Console.WriteLine(message);

            foreach (var str in strings)
                Console.WriteLine(str);
        }

        #region Генерация массива
        void GenerateArray(int minElements = 5, int maxElements = 10)
        {
            var numberElements = random.Next(minElements, maxElements);

            strings = new string[numberElements];

            for (var i = 0; i < strings.Length; i++)
            {
                strings[i] = GenerateWord();
            }
        }

        string GenerateWord(int minLength = 3, int maxLength = 7)
        {
            var str = "";
            var length = random.Next(minLength, maxLength);

            for (var i = 0; i < length; i++)
            {
                str += (char)random.Next('A', 'Z' + 1);
            }

            return str;
        }
        #endregion

        #region Сортировка (методом пузырька)
        delegate bool MinWord(string firstWord, string secondWord);
        public void SortedArray()
        {
            MinWord minWord = NeedSwap;

            for (var i = 0; i < strings.Length; i++)
            {
                for (int j = i + 1; j < strings.Length; j++)
                {
                    if (minWord(strings[i], strings[j]))
                    {
                        var temp = strings[i];
                        strings[i] = strings[j];
                        strings[j] = temp;
                    }
                }
            }

            OutputArray(sortedArrayMessage);
        }

        static bool NeedSwap(string firstWord, string secondWord)
        {
            if (firstWord.Length > secondWord.Length)
                return true;
            if (firstWord.Length < secondWord.Length)
                return false;
            for (var i = 0; i < firstWord.Length; i++)
            {
                if (firstWord[i] > secondWord[i])
                    return true;
                if (firstWord[i] < secondWord[i])
                    return false;
            }

            return false;
        }
        #endregion
    }
}
