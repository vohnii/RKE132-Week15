using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class gifts
        {
            string name;
            string gift;

            public gifts(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }
        }
        static void Main(string[] args)
        {
            List<gifts> frozenGift = new List<gifts>();
            string[] giftsFromFile = GetDataFromFile();

            foreach (string line in giftsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                gifts newGift = new gifts(tempArray[0], tempArray[1]);
                frozenGift.Add(newGift);
            }

            foreach (gifts giftFromList in frozenGift)
            {
                Console.WriteLine($"{giftFromList.Name} wants {giftFromList.Gift} for Christmas.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Marku\Downloads\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}