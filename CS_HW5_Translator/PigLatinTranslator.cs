


using System.Linq;

namespace CS_HW5_Translator
{
    public class PigLatinTranslator : Translator
    {

        public PigLatinTranslator()
        {
        }

        public string ConvertTo(string Word)
        {
            var Index = 1;
            var Length = Word.Length;
            var First = Word[0];
            var FirstPart = "";

            if (Vowels.Contains(First))
            {
                return Word + "way";
            }

            for (; Index < Length; Index++)
            {
                if (Vowels.Contains(Word[Index]) || Word[Index] == 'y')
                {
                    break;
                }
                else
                {
                    //doNothing();
                }
            }
            
            var LastPart = Word.Substring(0, Index) + "ay";
            
            if (char.IsUpper(First))
            {
                FirstPart = char.ToUpper(Word[Index++]) + Word.Substring(Index, Length - Index);
            }
            else
            {
                FirstPart = Word.Substring(Index, Length - Index);
            }

            return FirstPart + LastPart;
        }
    }
}