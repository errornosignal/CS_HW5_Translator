
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace CS_HW5_Translator
{
    /// <inheritdoc />
    /// <summary>
    /// Translator Class, Implements <see cref="ITranslatable"/>
    /// </summary>
    public class Translator : ITranslatable
    {
        public const string Language1 = PigLatinTranslator.PigLatin;
        public const string Language2 = PigGreekTranslator.PigGreek;
        public const string Vowels = "AEIOUaeiou";

        private const string ContractionRegexPattern = "[a-zA-Z][-'][a-zA-Z]"; /*allows translation of hyphenated words and contractions*/
        private string LeadingPunctuation = "";
        private string TrailingPunctuation = "";

        /// <summary>
        /// Translates given string to specified language.
        /// </summary>
        /// <param name="ToTranslate">string</param>
        /// <param name="Language">string</param>
        /// <returns>translated string</returns>
        public string Translate(string ToTranslate, string Language)
        {
            //split input on whitespace
            var Words = ToTranslate.Split(' ');
            var NewWordList = new ArrayList();
            
            foreach (var Word in Words)
            {
                //check for digits and symbols
                var HasDigitsOrSymbols = Word.Any(char.IsDigit) || Word.Any(char.IsSymbol);
                //check if string is all punctuation
                var IsAllPunctuation = IsAllPunct(Word);

                //translate only if string is free from digits or symbols and is not all punctuation
                if (!HasDigitsOrSymbols && !IsAllPunctuation)
                {
                    //remove leading and trailing punctuation
                    var TrimmedWord = TrimPunctuation(Word);

                    var TranslatedWord = "";
                    //do not translate if word contains internal punctuation, except for hyphenated words and contractions
                    if (!TrimmedWord.Any(char.IsPunctuation) || Regex.IsMatch(TrimmedWord, ContractionRegexPattern))
                    {
                        if (Word.Length > 0)
                        {
                            if (Language.Equals(Language1))
                            {
                                //new object instance
                                var PigLatinTranslator = new PigLatinTranslator();
                                //translate to PigLatin
                                TranslatedWord = PigLatinTranslator.ConvertTo(TrimmedWord);
                            }
                            else if (Language.Equals(Language2))
                            {
                                //new object instance
                                var PigGreekTranslator = new PigGreekTranslator();
                                //translate to PigGreek
                                TranslatedWord = PigGreekTranslator.ConvertTo(TrimmedWord);
                            }
                            else
                            {
                                /*doNothing();*/
                            }
                        }
                    }
                    else
                    {
                        //no translation performed
                        TranslatedWord = TrimmedWord;
                    }

                    //add punctuation back to word
                    var PunctuatedWord = this.LeadingPunctuation + TranslatedWord + this.TrailingPunctuation;
                    //add word to arraylist
                    NewWordList.Add(PunctuatedWord);
                }
                else
                {
                    //add unaltered word to arraylist
                    NewWordList.Add(Word);
                }
            }
            return string.Join(" ", NewWordList.ToArray());
        }

        /// <summary>
        /// Trims leading and trailing punctuation from given string.
        /// </summary>
        /// <param name="Word">string</param>
        /// <returns>trimmed string</returns>
        private string TrimPunctuation(string Word)
        {
            var RemoveFromStart = 0;
            var RemoveFromEnd = 0;
            this.LeadingPunctuation = "";
            this.TrailingPunctuation = "";

            //foreach loop to count leading puntuation
            foreach (var C in Word)
            {
                if (char.IsPunctuation(C))
                {
                    RemoveFromStart++;
                }
                else
                {
                    break;
                }

            }

            //reverse for loop to count trailing punctuation
            for (var i = Word.Length - 1; i >= 0; i--)
            {
                if (char.IsPunctuation(Word[i]))
                {
                    RemoveFromEnd++;
                }
                else
                {
                    break;
                }
            }
        
            //if no characters are punctuation
            if (RemoveFromStart == 0 && RemoveFromEnd == 0)
            {
                return Word;
            }
            else { /*doNothing();*/ }

            //if all characters are punctuation
            if (RemoveFromStart == Word.Length && RemoveFromEnd == Word.Length)
            {
                return "";
            }
            else { /*doNothing();*/ }

            //store leading and trailing punctuation as strings (will be re-added after translation)
            this.LeadingPunctuation = Word.Substring(0, RemoveFromStart);
            this.TrailingPunctuation = Word.Substring(Word.Length - RemoveFromEnd, RemoveFromEnd);

            //return translated string with leading and trailing punctuation removed
            return Word.Substring(RemoveFromStart, Word.Length - RemoveFromEnd - RemoveFromStart);
        }

        /// <summary>
        /// Checks if all characters in given string are punctuation.
        /// </summary>
        /// <param name="Word">string</param>
        /// <returns>true/false</returns>
        private static bool IsAllPunct(string Word)
        {
            foreach (var C in Word)
            {
                if (!char.IsPunctuation(C))
                {
                    return false;
                }
                else { /*doNothing(); */ }
            }
            return true;
        }

        /// <summary>
        /// Checks if all characters in given string are uppercase.
        /// </summary>
        /// <param name="Word">string</param>
        /// <returns>true/false</returns>
        public bool IsAllUpper(string Word)
        {
            foreach (var C in Word)
            {
                if (!char.IsUpper(C))
                {
                    return false;
                }
                else { /*doNothing(); */ }
            }
            return true;
        }
    }
}