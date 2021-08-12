using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace Dominio
{
    public class Password 
    {
        const string NOTES_INVALID_MESSAGE = "Las notas deben tener menos de 250 caracteres";
        const string SITE_LENGTH_INVALID_MESSAGE = "El sitio debe tener entre 3 y 25 caracteres";
        const string USERNAME_LENGTH_INVALID_MESSAGE = "El usuario debe tener entre 5 y 25 caracteres";
        const string PASSWORD_LENGTH_INVALID_MESSAGE = "La contrasena debe tener entre 5 y 25 caracteres";

        const int NOTES_MAX_LENGTH = 250;
        const int INPUTS_MAX_LENGTH = 25;
        const int SITE_MIN_LENGTH = 3;
        const int USER_MIN_LENGTH = 5;
        const int PASSWORD_MIN_LENGTH = 5;
        const int MAX_RED_STRENGTH = 8;
        const int MAX_ORANGE_STRENGTH = 14;
        public List<DataBreachesResult> DataBreachesResults { get; set; } 
        public Category CategoryId { get; set; }
        public int Id { get; set; }
        public string Category { get; set; }
        public string Site { get; set; }
        public string Username { get; set; }

        public string Pass { get; set; }
       // public string Pass {
         //   get { return DecryptPassword(passwordEncrypted); }
           // set { this.passwordEncrypted = EncryptPassword(value); }
        //}
        public int PasswordLength { get; set; }
        public bool UpperCase { get; set; }
        public bool LowerCase { get; set; }
        public bool Digits { get; set; }
        public bool Special { get; set; }
        public string Notes { get; set; }
        public ColorStrength Strength { get; set; }
        public bool Shared { get; set; }
        public DateTime DateModified { get; set; }
        public bool isUpdated { get; set; }
        public List<User> SharedWith { get; set; }
        public enum ColorStrength
        {
            Green,
            LightGreen,
            Yellow,
            Orange,
            Red,
        }
        public Password()
        {

        }
        static bool Validate(string username, string password, string site, string notes)
        {
            if (notes.Length > NOTES_MAX_LENGTH)
            {
                throw new InvalidOperationException(NOTES_INVALID_MESSAGE);
            }
            else if ((site.Length > INPUTS_MAX_LENGTH || site.Length < SITE_MIN_LENGTH))
            {
                throw new InvalidOperationException(SITE_LENGTH_INVALID_MESSAGE);
            }
            else if ((username.Length > INPUTS_MAX_LENGTH || username.Length < USER_MIN_LENGTH))
            {
                throw new InvalidOperationException(USERNAME_LENGTH_INVALID_MESSAGE);
            }
            else if ((password.Length > INPUTS_MAX_LENGTH || password.Length < PASSWORD_MIN_LENGTH))
            {
                throw new InvalidOperationException(PASSWORD_LENGTH_INVALID_MESSAGE);
            }
            return true;
        }

        public Password(string category, string site, string username, string password, int length, bool uppercase, bool lowercase, bool digits, bool special, string notes)
        {
            if (Validate(username, password, site, notes))
            {
                Category = category;
                
                Site = site;
                
                Username = username;

                Pass = EncryptPassword(password);
                
                PasswordLength = password.Length;
                
                UpperCase = uppercase;
                
                LowerCase = lowercase;
                
                Digits = digits;
                
                Special = special;
                
                Notes = notes;
                
                Strength = CalculateStrength(password);
                
                DateModified = DateTime.Now;
                
                SharedWith = new List<User>();
            }
        }

        public Password(string category, string site, string username, int length, bool uppercase, bool lowercase, bool digits, bool special, string notes)
        {
            Category = category;
            
            Site = site;
            
            Username = username;

            Pass = EncryptPassword(Generate(length, uppercase, lowercase, digits, special));
            
            PasswordLength = length;
            
            UpperCase = uppercase;
            
            LowerCase = lowercase;
            
            Digits = digits;
            
            Special = special;
            
            Notes = notes;
            
            Strength = CalculateStrength(DecryptPassword(Pass));
            
            Shared = false;

            DateModified = DateTime.Now;

            SharedWith = new List<User>();

        }

        public void Update(string newCategory, string newSite, string newUser, string newPass, int newLenght, bool upperCase, bool lowerCase, bool digits, bool specials, string newNotes)
        {
            if (Validate(newUser, newPass, Site, newNotes))
            {
                Category = newCategory;

                Site = newSite;
                
                Username = newUser;

                Pass = EncryptPassword(newPass);
                
                PasswordLength = newPass.Length;
                
                UpperCase = upperCase;
                
                LowerCase = lowerCase;
                
                Digits = digits;
                
                Special = specials;
                
                Notes = newNotes;
                
                DateModified = DateTime.Now;

                Strength = CalculateStrength(newPass);
            }
        }

        public static string Generate(int length,bool uppercase,bool lowercase, bool digits, bool special)
        {
            PasswordGenerator passwordGenerator = new PasswordGenerator();

            string pass = passwordGenerator.GeneratePassword(lowercase, uppercase, digits, special, length);

            return pass;
        }

        public ColorStrength CalculateStrength(string password)
        {
            bool hasLowerCase = password.Any(ch => Char.IsLower(ch));
            bool hasUpperCase = password.Any(ch => Char.IsUpper(ch));
            bool hasSpecialCharacters = password.Any(ch => !Char.IsLetterOrDigit(ch));
            bool hasDigits = password.Any(ch => Char.IsDigit(ch));

            ColorStrength PassStrength = ColorStrength.Yellow;

            if (password.Length < MAX_RED_STRENGTH) PassStrength = ColorStrength.Red;

            if (MAX_RED_STRENGTH <= password.Length && password.Length <= MAX_ORANGE_STRENGTH) PassStrength = ColorStrength.Orange;

            if (password.Length > MAX_ORANGE_STRENGTH)
            {

                if (( hasLowerCase && hasUpperCase && hasSpecialCharacters) && hasDigits)
                    PassStrength = ColorStrength.Green;
                else if ((hasLowerCase && hasUpperCase) ||
                       (hasLowerCase && hasUpperCase && hasDigits) ||
                       (hasLowerCase && hasUpperCase && hasSpecialCharacters) ||
                       (hasLowerCase && hasDigits && hasSpecialCharacters) ||
                       (hasUpperCase && hasDigits && hasSpecialCharacters)
                    )
                    PassStrength = ColorStrength.LightGreen;
            }
            return PassStrength;
        }
        public bool isSafePassword()
        {
            return Strength == ColorStrength.Green || Strength == ColorStrength.LightGreen;
        }

        public string EncryptPassword(string password)
        {
            IEncryptor target = new Adapter();
            string pass = target.Encrypt(password);
            return pass;
        }

        public string DecryptPassword(string password)
        {
            IEncryptor target = new Adapter();
            string pass = target.Decrypt(password);
            return pass;
        }

        public override string ToString()
        {
            return "[" + Category + "] " + "[" + Site + "] "+"["+Username+"]";
        }
    }
}