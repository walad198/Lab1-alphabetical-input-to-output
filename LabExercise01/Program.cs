using System;
//makes files work
using System.IO;
//makes checking if a char is in an array of chars work
using System.Linq;
//makes lists work as arrays of chars arent expansive
using System.Collections.Generic;

namespace LabExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            //standard
            Console.WriteLine("Hello World!");
            //checking if files in right place
            if (File.Exists("input.txt")) Console.WriteLine("File exists");
            //string to keep data
            string data = "";
            //reading all data into string from file
            using (var reader = new StreamReader("input.txt"))
            {
                data = reader.ReadToEnd();
            }
            //stores all types of punctuation found in text in check
            List<char> check = new List<char>();
            //make data available outside loop
            string data2 = "";
            foreach (char isit in data)
            {
                if (isit != ' ' && Char.IsPunctuation(isit) == true)
                {
                    if (check.Contains(isit))
                    {
                        
                    }
                    else
                    {
                        check.Add(isit);
                       
                    }
                }
            }
            int count = check.Count();
            //testing whats in check
            for (int o = 0; o < count; o++)
            {
                Console.Write(check[o] + " ");
            }
            Console.WriteLine("done");
            Console.WriteLine(data);
            //removing all punctuation from data
            foreach(char p in check)
            {
                //convert char to string
                string rep = p.ToString();
                data = data.Replace(rep, "");
                data2 = data;
            }
            //testing whats in data
            Console.WriteLine(data2);
            //converting data2 to lowercase
           data2 = data2.ToLower();
            Console.WriteLine(data2);
            //splitting the data2 into an array of words
            string[] brokensentence = data2.Split(' ');
            //sorting the array in alphabetical order
            Array.Sort(brokensentence);
            //testing whats in brokensentence
            for(int y =0; y < brokensentence.Length; y++)
            {
                Console.Write(brokensentence[y] + " ");
            }
            //writing data to new file called output
            using (var writer = new StreamWriter("output.txt"))
            {
                foreach (var word in brokensentence)
                {
                    writer.Write(word + " ");
                }
            }
    }
    }
}
