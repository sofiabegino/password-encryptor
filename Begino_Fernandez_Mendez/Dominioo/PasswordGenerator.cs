using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class PasswordGenerator
    {
            const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
            const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string NUMBERS = "123456789";
            const string SPECIALS = @"~}|{'`_^]\[@?>=<;:/.-,+*)('&%$#!";

            public string GeneratePassword(bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial,
                int passwordSize)
            {
                char[] _password = new char[passwordSize];
                foreach (char item in _password)
                {
                     _password[item] = ' ';
                }
                string charSet = "";
                System.Random _random = new Random();
                int counter;
                 
                if (useLowercase)
                {
                    _password[_random.Next(0, passwordSize - 1)] = LOWER_CASE[_random.Next(0,LOWER_CASE.Length-1)];
                    charSet += LOWER_CASE;
                }
                if (useUppercase)
                {
                    _password[_random.Next(0, passwordSize - 1)] = UPPER_CASE[_random.Next(0, UPPER_CASE.Length - 1)];
                    charSet += UPPER_CASE;
                }

                if (useNumbers)
                {
                    _password[_random.Next(0, passwordSize - 1)] = NUMBERS[_random.Next(0, NUMBERS.Length - 1)];
                    charSet += NUMBERS;
                }
                if (useSpecial)
                {
                    _password[_random.Next(0, passwordSize - 1)] = SPECIALS[_random.Next(0, SPECIALS.Length - 1)];
                    charSet += SPECIALS;
                }
                for (counter = 0; counter < passwordSize; counter++)
                {
                    _password[counter] = charSet[_random.Next(charSet.Length - 1)];
                }
                return String.Join(null, _password);
            }
    }
}
