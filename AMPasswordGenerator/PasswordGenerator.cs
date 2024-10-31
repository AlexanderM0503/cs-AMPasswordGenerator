namespace AMPasswordGenerator
{
    internal class PasswordGenerator
    {
        Random random = new Random();

        public string GetCharUp()
        {
            string[] charsUp = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            return charsUp[random.Next(26)];
        }

        public string GetCharLow()
        {
            string[] charsLow = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "k", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            return charsLow[random.Next(26)];
        }

        public string GetDigits()
        {
            string[] digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            return digits[random.Next(10)];
        }

        public string GetSpChar()
        {
            string[] spChars = { "!", "'", "$", "%", "&", "(", ")", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "[", "]", "^", "_", "{", "|", "}", "~", "`" };
            return spChars[random.Next(28)];
        }

        public string GetPasswordString(bool charUp, bool charLow, bool digit, bool spChar, int length)
        {
            string passwordString = "";
            int i = 0;
            int iChar = 0;

            while (i < length)
            {
                iChar = random.Next(4);

                if (charUp == true & iChar == 0)
                {
                    passwordString += GetCharUp();
                }

                if (charLow == true & iChar == 1)
                {
                    passwordString += GetCharLow();
                }

                if (digit == true & iChar == 2)
                {
                    passwordString += GetDigits();
                }

                if (spChar == true & iChar == 3)
                {
                    passwordString += GetSpChar();
                }

                i = passwordString.Length;
            }

            return passwordString;
        }
    }
}
