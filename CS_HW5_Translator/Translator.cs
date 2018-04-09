
using System;
using System.Collections;

namespace CS_HW5_Translator
{
    public class Translator : ITranslatable
    {
        public Translator()
        {   
        }

        private const string PigLatin = "PigLatin";
        private const string PigGreek = "PigGreek";
        public const string Vowels = "AEIOUaeio";
        
        public string Translate(string ToTranslate, string Language)
        {
            string[] Words = ToTranslate.Split(' ');
            var NewWordList = new ArrayList();
            var NewWordString = "";

            if (Language.Equals(PigLatin))
            {
                foreach (var Word in Words)
                {
                    var PigLatinTranslator = new PigLatinTranslator();
                    NewWordList.Add(PigLatinTranslator.ConvertTo(Word));
                }
            }
            else if (Language.Equals(PigGreek))
            {
                foreach (var Word in Words)
                {
                    var PigGreekTranslator = new PigGreekTranslator();
                    NewWordList.Add(PigGreekTranslator.ConvertTo(Word));
                }
            }
            else
            {
                //doNothing();
            }

            NewWordString = string.Join(" ", NewWordList.ToArray());
            return NewWordString;
        }


        public string Translate()
        {
            throw new NotImplementedException();
        }
    }
}