using System;
using System.Collections.Generic;

namespace Week6_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int F = 0;
            
            faceBook();
            ProblemTwo();

        }
       
           
            static void faceBook()
            {
                List<string> names = new List<string>();

                while (true)
                {
                    string name = AskForName();

                    if (string.IsNullOrEmpty(name))
                        break;

                    names.Add(name);
                    Console.WriteLine(GetLikesMessage(names));
                }
            }

            static string AskForName()
            {
                Console.WriteLine("Enter a name: (Leave it empty to close the program)");
                return Console.ReadLine();
            }

            static string GetLikesMessage(List<string> names)
            {
                if (names.Count > 2)
                    return names[0] + ", " + names[1] + " and " + GetExtraLikes(names).Count + " liked your post";
                if (names.Count == 2)
                    return names[0] + " and " + names[1] + " liked your post";

                return names[0] + " liked your post";
            }

            static List<string> GetExtraLikes(List<string> names)
            {
                return names.GetRange(2, names.Count - 2);
            }
        

        static void ProblemTwo()
        {
            Dictionary<char, int> properties = new Dictionary<char, int>();

            string userInput = "";

            do
            {
                Console.WriteLine("Enter a word:");
                userInput = Console.ReadLine();

                int i = 0;
                
               
             for(i = 0; i < userInput.Length; i++)
                {
                    char t = userInput[i];

                    if (properties.ContainsKey(t))
                    {
                        properties[t] += 1;

                    }
                    else
                    {
                        properties.Add(t, 1);
                    }
                }

            } while (userInput != "OK");
        
            foreach(KeyValuePair<char, int> kvp in properties)
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value);
            }
        }
    }
}
