
using System;
using System.Collections;
using System.Linq;

namespace CS_HW5_Translator
{
    public class Translator : ITranslatable
    {
        public Translator()
        {
        }

        private const string PigLatin = "PigLatin";
        private const string PigGreek = "PigGreek";
        public const string Vowels = "AEIOUaeiou";

        string LeadingPunctuation = "";
        string TrailingPunctuation = "";

        public string Translate(string ToTranslate, string Language)
        {
            string[] Words = ToTranslate.Split(' ');
            var NewWordList = new ArrayList();

            if (Language.Equals(PigLatin))
            {
                foreach (var Word in Words)
                {
                    var HasDigitsOrSymbols = Word.Any(C => char.IsDigit(C)) || Word.Any(C => char.IsSymbol(C));
                    
                    //do not translate if word contains digits or symbols
                    if (!HasDigitsOrSymbols)
                    {
                        //new instance of class
                        var PigLatinTranslator = new PigLatinTranslator();
                        //remove leading and trailing punctuation
                        var TrimmedWord = TrimPunctuation(Word);

                        //perform translation
                        var TranslatedWord = "";
                        //do not translate if word contains internal punctuation 
                        if (!TrimmedWord.Any(C => char.IsPunctuation(C)))
                        {
                            TranslatedWord = PigLatinTranslator.ConvertTo(TrimmedWord);
                        }
                        else
                        {
                            TranslatedWord = TrimmedWord;
                        }

                        //add punctuation back to word
                        var PunctuatedWord = LeadingPunctuation + TranslatedWord + TrailingPunctuation;
                        //add word to arraylist
                        NewWordList.Add(PunctuatedWord);
                    }
                    else
                    {
                        //add unaltered word to arraylist
                        NewWordList.Add(Word);
                    }
                }
            }
            else if (Language.Equals(PigGreek))
            {
                foreach (var Word in Words)
                {
                    var HasDigitsOrSymbols = Word.Any(C => char.IsDigit(C)) || Word.Any(C => char.IsSymbol(C));

                    //do not translate if word contains digits or symbols
                    if (!HasDigitsOrSymbols)
                    {
                        //new instance of class
                        var PigGreekTranslator = new PigGreekTranslator();
                        //remove leading and trailing punctuation
                        var TrimmedWord = TrimPunctuation(Word);

                        //perform translation
                        var TranslatedWord = "";
                        //do not translate if word contains internal punctuation 
                        if (!TrimmedWord.Any(C => char.IsPunctuation(C)))
                        {
                            TranslatedWord = PigGreekTranslator.ConvertTo(TrimmedWord);
                        }
                        else
                        {
                            TranslatedWord = TrimmedWord;
                        }

                        //add punctuation back to word
                        var PunctuatedWord = LeadingPunctuation + TranslatedWord + TrailingPunctuation;
                        //add word to arraylist
                        NewWordList.Add(PunctuatedWord);
                    }
                    else
                    {
                        //add unaltered word to arraylist
                        NewWordList.Add(Word);
                    }
                }
            }
            else
            {
                //doNothing();
            }
            return string.Join(" ", NewWordList.ToArray());
        }


        public string TrimPunctuation(string Word)
        {
            LeadingPunctuation = "";
            TrailingPunctuation = "";

            //count start punctuation
            var RemoveFromStart = 0;
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

            //count end punctuation
            var RemoveFromEnd = 0;
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
        
            //no characters were punctuation
            if (RemoveFromStart == 0 &&
                RemoveFromEnd == 0)
            {
                return Word;
            }

            //all characters were punctuation
            if (RemoveFromStart == Word.Length &&
                RemoveFromEnd == Word.Length)
            {
                return "";
            }

            //get leading and trailing punctuation as strings
            LeadingPunctuation = Word.Substring(0, RemoveFromStart);
            TrailingPunctuation = Word.Substring(Word.Length - RemoveFromEnd, RemoveFromEnd);

            return Word.Substring(RemoveFromStart,
                Word.Length - RemoveFromEnd - RemoveFromStart);
        }
        
        public string Translate()
        {
            throw new NotImplementedException();
        }
    }
}