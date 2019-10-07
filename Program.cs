using System;
using System.Collections.Generic;

namespace words
{
    class Program
    {
        static void Main(string[] args)
       {
        /*
        Create a dictionary with key value pairs to
        represent words (key) and its definition (value)
        */
        var wordsAndDefinitions = new Dictionary<string, string>() {
            {"word", "defines something"},
            {"jesus", "the way"},
            {"baby", "small potato"},
            {"baby jesus", "they way as a small potato"}
        };

        // Add several more words and their definitions
        wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");

        /*
            Use square brackets to get the definition of two of the
            words and then output them to the console
        */
        Console.WriteLine(wordsAndDefinitions["word"]);
        Console.WriteLine(wordsAndDefinitions["jesus"]);

        /*
            Below, loop over the wordsAndDefinitions dictionary to get the following output:
                The definition of (WORD) is (DEFINITION)
        */
        foreach (KeyValuePair<string, string> def in wordsAndDefinitions) {
            Console.WriteLine($"The definition of {def.Key} is {def.Value}");
        }

        var dictionaryOfWords = new List<Dictionary<string, string>>();

        // Create dictionary to represent a few words
        var excitedWord = new Dictionary<string, string>();

        // Add each of the 4 bits of data about the word to the Dictionary
        excitedWord.Add("word", "excited");
        excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
        excitedWord.Add( "part of speech", "adjective");
        excitedWord.Add("example sentence", "I am excited to learn C#!");

        // Add Dictionary to your `dictionaryOfWords` list
        dictionaryOfWords.Add(excitedWord);
        dictionaryOfWords.Add(wordsAndDefinitions);

        // Iterate the List of Dictionaries
        foreach (var dict in dictionaryOfWords)
        foreach (var keyValue in dict)
        Console.WriteLine($"{keyValue.Key} means: {keyValue.Value}");

        }
    }
}

