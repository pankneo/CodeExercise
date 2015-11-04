using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Caesar_Cipher
{
    /// <summary>
    /// Caesar class implements Caesar Cipher's encryption Algorithm
    /// Assumptions: 1) Shift under consideration is right(forward) shift
    ///              2) Hence, shift is assumed to be always positive.
    /// </summary>
    public class Caesar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================");
            Console.WriteLine("CAESAR CIPHER");
            Console.WriteLine("=================");
            Console.WriteLine();
            Console.Write("Enter the string to encrypt :");
            String plainText = Console.ReadLine();
            Console.Write("Enter the integer shift :");
            int shift = Int32.Parse(Console.ReadLine());
                            
            Caesar caesar = new Caesar();
            String cipherText = caesar.Encrypt(plainText, shift);
            Console.WriteLine("Encrypted Text :"+cipherText);
            Console.ReadKey();
        }

        /// <summary>
        /// Caesar Encryption function that encrypts the
       ///  given string using the shift.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        public string Encrypt(string input, int shift)
        {
            // Converting higher shifts with base of 26 as the ROTATION brings A after Z.
            shift = shift % 26;
            // Convert string to character array.
            char[] inputCharArr = input.ToCharArray();

            // Update  character array to reflect the characters after shift
            for (int i = 0; i < inputCharArr.Length; i++)
            {
                int currentChar = (int)inputCharArr[i];
                inputCharArr[i] = PerformShift(currentChar,shift);
            }

            return new string(inputCharArr);

        }


        /// <summary>
        /// Perform the actual shifting using the provided shift
       ///  by using ASCII notation of the characters
        /// </summary>
        /// <param name="currentChar"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        private char PerformShift(int currentChar, int shift)
        {
            int newChar = currentChar + shift;

            // Maintaining the characters within the bounds of UPPER CASE ASCII characters. 
            if (currentChar >= 65 && currentChar <= 90)
            {               
                if (newChar > 90)
                    newChar = newChar - 26;
            }
            // Maintaining the characters within the bounds of LOWER CASE ASCII characters.
            else if (currentChar >= 97 && currentChar <= 122)
            {
                if (newChar > 122)
                    newChar = newChar - 26;
            }
            // Returning special case characters as is (Eg; " %^&*,)
            else
            {
                newChar = currentChar;
            }           
            return (char)newChar;
        }

       
    }   
}
