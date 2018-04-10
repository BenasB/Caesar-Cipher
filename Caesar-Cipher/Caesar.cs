using System;
using System.Text;

namespace Caesar_Cipher
{
    static class Caesar
    {
        public static string Cipher(string input, int shift)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    builder.Append(' ');
                    continue;
                }

                int startingNumber = (char.IsUpper(input[i])) ? 65 : 97;

                int a = (input[i] - startingNumber + shift);
                int newChar = startingNumber + Mod(a, 26);
                builder.Append((char)newChar);
            }

            return builder.ToString();
        }

        public static string Decipher(string input, int shift)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    builder.Append(' ');
                    continue;
                }

                int startingNumber = (char.IsUpper(input[i])) ? 65 : 97;

                int a = (input[i] - startingNumber - shift);
                int newChar = startingNumber + Mod(a, 26);
                builder.Append((char)newChar);
            }

            return builder.ToString();
        }

        static int Mod(int x, int m)
        {
            return (x % m + m) % m;
        }
    }
}
