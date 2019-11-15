using System;
using System.Collections.Generic;

namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("fingers", "the things on your hand, you have five or six");
            wordsAndDefinitions.Add("to blathe", "to bluff");
            wordsAndDefinitions.Add("fireswamp", "a place to be feared");
            wordsAndDefinitions.Add("inconceivable", "hard to believe");
            wordsAndDefinitions.Add("marriage", "it iss what brings us together today");
            wordsAndDefinitions.Add("secret", "he is not left-handed");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            Console.WriteLine(wordsAndDefinitions["marriage"]);
            Console.WriteLine(wordsAndDefinitions["to blathe"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"the definition of {word.Key} is {word.Value}");
            }
            Console.WriteLine(@"                                       /\
                                      /  \
                                     / /\ \
                                    / /  \ \
                                   / /    \ \
                                  / /      \ \
                                 / /        \ \
                                / /          \ \
                               / /            \ \
_ _____  _ _ _  ___ __________/ /              \ \_____________________________
`|_   _|| |_| || __|___________/                \________________________  ,-'
   | |`-|  _  || _|                                                  ,-',-'
   |_|`-|_| |_||___|                                             _,-',-'
  ____    `-.`-____        ____        ___      ___  ___  _____,-_,-'________
 |    \      `/    |    ,-'    `-.    |   |    |   ||   ||        | /        |
 |     \     /     |-.,'  __  __  `.  |   |    |   ||   ||    ____||    _____|
 |      \   /      |-/   /  \/  \   \ |   |    |   ||   ||   |____ |   ____
 |       \_/       ||    \      /    ||   |    |   ||   ||        ||        \
 |   |\       /|   ||     |         | \   \  /   / |   ||    ____| \____    |
 |   | \     / |   |/\    |____|    /   \   \/   /  |   ||   |____  _____   |
 |   |  \   /  |   | / .  ,' | `. ,'   , \      /   |   ||        ||         |
 |___|   \_/   |___|/   `-.____,-'  ,-',`-\____/    |___||________||________/
                 / /             ,-',-' `-.`-.             \ \
                / /           ,-',-'       `-.`-.           \ \
               / /         ,-',-'             `-.`-.         \ \
              / /       ,-',-'                   `-.`-.       \ \
             / /     ,-',-'                         `-.`-.     \ \
            / /   ,-',-'                               `-.`-.   \ \
           / / ,-',-'                                     `-.`-. \ \
          / /-',-'                                           `-.`-\ \
         /_,-'`                                                 `'-._\");

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();
            Dictionary<string, string> funnyWord = new Dictionary<string, string>();
            Dictionary<string, string> wordWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "about to pee your pants");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example", "I'm excited");
            funnyWord.Add("word", "funny");
            funnyWord.Add("definition", "haha");
            funnyWord.Add("part of speed", "adjective");
            funnyWord.Add("example", "I'm funny");
            wordWord.Add("word", "word");
            wordWord.Add("definition", "part of a sentence");
            wordWord.Add("part of speech", "nouny");
            wordWord.Add("example", "word to your mother");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);
            dictionaryOfWords.Add(funnyWord);
            dictionaryOfWords.Add(wordWord);
            

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (var word in dictionaryOfWords)
            
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (var item in word)
                
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            };
        
        }

    }
}