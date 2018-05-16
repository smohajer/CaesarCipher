using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public class Cypher

    {
        public string StringCypher(string input)
        {
            //Splitting input into two by the colon, index zero is cypher and index 1 is the string we are changing
            string[] parse = input.Split(':');

            //If the string has numbers, we can only move it 10 spots
            int numberMover = Convert.ToInt32(parse[0]) % 10;

            // letter can be moved 26 spots, no matter the number input to move it
            int letterMover = Convert.ToInt32(parse[0]) % 26;

            //assigning parse index one back into input string to gain memory back
            input = parse[1];

            // initializing output string
            string output = "";

            // establishing what he min and max of numers/letters are
            int minNumber = Convert.ToInt32('0');
            int maxNumber = Convert.ToInt32('9');
            int minLowerCase = Convert.ToInt32('a');
            int maxLowerCase = Convert.ToInt32('z');
            int minUpperCase = Convert.ToInt32('A');
            int maxUpperCase = Convert.ToInt32('Z');

            for (int i = 0; i < input.Length; i++)
            {
                // gives us the ASCII number for wach element in string
                int inputIntConversion = Convert.ToInt32(input[i]);

                //What the new number/letter will be after we add the "mover", still ASCII
                int newAsciiNumber = inputIntConversion + numberMover;
                int newAsciiLetter = inputIntConversion + letterMover;

                // making sure its inside the main range
                if (inputIntConversion >= minNumber && inputIntConversion <= maxNumber)

                    // making sure it doesnt go out of bounds, simple check
                    if (newAsciiNumber < minNumber)
                        output += Convert.ToChar(newAsciiNumber + 10);

                    else if (newAsciiNumber > maxNumber)
                        output += Convert.ToChar(newAsciiNumber - 10);

                    else
                        output += Convert.ToChar(newAsciiNumber);
                // doing the same as above for lower case letters
                else if (inputIntConversion >= minLowerCase && inputIntConversion <= maxLowerCase)

                    if ((newAsciiLetter) < minLowerCase)
                        output += Convert.ToChar(newAsciiLetter + 26);

                    else if (newAsciiLetter > maxLowerCase)
                        output += Convert.ToChar(newAsciiLetter - 26);

                    else
                        output += Convert.ToChar(newAsciiLetter);
                // fianlly checing for upper case letters
                else if (inputIntConversion >= minUpperCase && inputIntConversion <= maxUpperCase)

                    if (newAsciiLetter < minUpperCase)
                        output += Convert.ToChar(newAsciiLetter + 26);

                    else if (newAsciiLetter > maxUpperCase)
                        output += Convert.ToChar(newAsciiLetter - 26);

                    else
                        output += Convert.ToChar(newAsciiLetter);

                // everything else will be just copied into output string
                else
                    output += input[i];
            }
            return output;
        }
    }
}
