
namespace CS_HW5_Translator
{
    /// <inheritdoc />
    /// <summary>
    /// PigGreekTranslator Class : Extends <see cref="Translator"/>
    /// </summary>
    public class PigGreekTranslator : Translator
    {
        public const string PigGreek = "Pig Greek";

        /// <summary>
        /// Converts givent string to Pig Greek.
        /// </summary>
        /// <param name="Word">string</param>
        /// <returns>translated string</returns>
        public string ConvertTo(string Word)
        {
            var Index = 1;
            var Length = Word.Length;
            var First = Word[0];
            var FirstPart = "";
            var LastPart = "";

            if (Vowels.Contains(First.ToString()))
            {
                if (IsAllUpper(Word))
                {
                    return Word + "OI";
                }
                else
                {
                    return Word + "oi";
                }
            }

            if (!IsAllUpper(Word))
            {
                Word = Word.ToLower();
            }
            else { /*doNothing();*/ }

            for (; Index < Length; Index++)
            {
                if (Vowels.Contains(Word[Index].ToString()) || Word[Index] == 'y' || Word[Index] == 'Y')
                {
                    break;
                }
                else { /*doNothing();*/ }
            }

            if (IsAllUpper(Word))
            {
                LastPart = Word.Substring(0, Index) + "OMATOS";
            }
            else
            {
                LastPart = Word.Substring(0, Index) + "omatos";
            }

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