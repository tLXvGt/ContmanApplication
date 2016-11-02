using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContmanApplication
{
    class AnalyseText
    {
        public Dictionary<string, int> listOfUsedChars = new Dictionary<string, int>();

        private Match regexMatch, regexMatch2;
        private int allCharsCount = 0;
        private int allWordsCount = 0;
        private int counter = 0;

        // regular expressions
        private string regexPatternChars = @".";
        private string regexPatternWords = @"\w+";
        private string regexPatternSentences = @"([A-Z][^\.]*\.)";
        private string regexPatternParagraphs = @"\n[A-Z]";

        private string inputParameter;
        
        public AnalyseText(string input)
        {
            this.inputParameter = input;
        }

        public int CountCharacters()
        {
            regexMatch = Regex.Match(inputParameter, regexPatternChars); // @"."
            counter = 0;
            while (regexMatch.Success)
            {
                counter++;
                regexMatch = regexMatch.NextMatch();
            }
            return counter;
        }

        public Tuple<int, double> CountWordsAndAverageLettersPerWord()
        {
            regexMatch = Regex.Match(inputParameter, regexPatternWords); // @"\w+"
            counter = 0;
            allCharsCount = 0;
            while (regexMatch.Success)
            {
                counter++;
                allCharsCount += regexMatch.Length;
                regexMatch = regexMatch.NextMatch();
            }

            double avg = (counter == 0) ? 0.0 : ((double)allCharsCount / (double)counter);

            // This method could be split into two methods returning one value each, 
            // but returning Tuple is more efficient, as two calculations are made
            // in one while loop (instead of two).

            return new Tuple<int, double>(counter, avg);
        }

        public Tuple<int, double> CountSentencesAndAverageWordsPerSentence()
        {
            regexMatch = Regex.Match(inputParameter, regexPatternSentences); // @"([A-Z][^\.]*\.)"
            counter = 0;
            allWordsCount = 0;
            while (regexMatch.Success)
            {
                // count up words in found sentence
                regexMatch2 = Regex.Match(regexMatch.Value, regexPatternWords);
                while (regexMatch2.Success)
                {
                    allWordsCount++;
                    regexMatch2 = regexMatch2.NextMatch();
                }

                counter++;
                regexMatch = regexMatch.NextMatch();
            }

            double avg = (counter == 0) ? 0.0 : ((double)allWordsCount / (double)counter);

            // This method could be split into two methods returning one value each, 
            // but returning Tuple is more efficient, as two calculations are made
            // in one while loop (instead of two).

            return new Tuple<int, double>(counter, avg);
        }
        
        public int CountParagraphs()
        {
            regexMatch = Regex.Match(inputParameter, regexPatternParagraphs); // @".\n"
            counter = 0;
            while (regexMatch.Success)
            {
                counter++;
                regexMatch = regexMatch.NextMatch();
            }
            return counter + 1;
        }

        public void CountUniqueCharacters()
        {
            regexMatch = Regex.Match(inputParameter, @"[^ \n]");
            while (regexMatch.Success)
            {
                if (!listOfUsedChars.ContainsKey(regexMatch.Value))
                {
                    listOfUsedChars.Add(regexMatch.Value, 1);
                }
                else
                {
                    listOfUsedChars[regexMatch.Value]++;
                }
                regexMatch = regexMatch.NextMatch();
            }
        }

        public string GetKeyAtIndex(int index)
        {
            return listOfUsedChars.OrderByDescending(n => n.Value).ElementAt(index).Key.ToString();
        }
    }
}
