/*
Program: Phone Dialing Program
Developer: Johnny Romano
*/
using System;

namespace PhoneDialingProgram
{
    class Program
    {
        static void GetInput(ref char C1, ref char C2, ref char C3, ref char C4, ref char C5, ref char C6, ref char C7)
        {
            Console.Write("Enter a 7 character phone number: ");
            C1 = Convert.ToChar(Console.Read());
            C2 = Convert.ToChar(Console.Read());
            C3 = Convert.ToChar(Console.Read());
            C4 = Convert.ToChar(Console.Read());
            C5 = Convert.ToChar(Console.Read());
            C6 = Convert.ToChar(Console.Read());
            C7 = Convert.ToChar(Console.Read());

            Console.ReadLine();
        }

        static int ProcessInput(ref char C1, ref char C2, ref char C3, ref char C4, ref char C5, ref char C6, ref char C7)
        {
            if (ToDigit(ref C1) == -1)
                return -1;
            if (ToDigit(ref C2) == -1)
                return -1;
            if (ToDigit(ref C3) == -1)
                return -1;
            if (ToDigit(ref C4) == -1)
                return -1;
            if (ToDigit(ref C5) == -1)
                return -1;
            if (ToDigit(ref C6) == -1)
                return -1;
            if (ToDigit(ref C7) == -1)
                return -1;

            if (C1 == '9' && C2 == '1' && C3 == '1')
                return -1;
            if (C1 == '0')
                return -1;
            return 0;
        }
        static int ToDigit(ref char digit)
        {
            digit = char.ToUpper(digit);
            switch(digit)
            {
                case '0': break;
                case '1': break;
                case '2': break;
                case '3': break;
                case '4': break;
                case '5': break;
                case '6': break;
                case '7': break;
                case '8': break;
                case '9': break;
                case 'A': case 'B': case 'C': digit = '2'; break;
                case 'D': case 'E': case 'F': digit = '3'; break;
                case 'G': case 'H': case 'I': digit = '4'; break;
                case 'J': case 'K': case 'L': digit = '5'; break;
                case 'M': case 'N': case 'O': digit = '6'; break;
                case 'P': case 'Q': case 'R': case 'S': digit = '7'; break;
                case 'T': case 'U': case 'V': digit = '8'; break;
                case 'W': case 'X': case 'Y': case 'Z': digit = '9'; break;

                default: return -1;
            }

            return 0;
        }



        static void ShowResults(ref char C1, ref char C2, ref char C3, ref char C4, ref char C5, ref char C6, ref char C7)
        {
            Console.WriteLine("The converted phone number is: " + C1 + C2 + C3 + "-" + C4 + C5 + C6 + C7);
        }


        static void Main(string[] args)
        {
            char C1 = 'a', C2 = 'a', C3 = 'a', C4 = 'a', C5 = 'a', C6 = 'a', C7 = 'a';
            GetInput(ref C1, ref C2, ref C3, ref C4, ref C5, ref C6, ref C7);

            int returnVal = ProcessInput(ref C1, ref C2, ref C3, ref C4, ref C5, ref C6, ref C7);

            if (returnVal == -1)
                Console.WriteLine("Invalid input, please try again");
            else
                ShowResults(ref C1, ref C2, ref C3, ref C4, ref C5, ref C6, ref C7);
            Console.ReadLine();
        }
    }
}