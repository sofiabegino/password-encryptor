using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominio
{
    public class CreditCard
    {
        public List<DataBreachesResult> DataBreachesResults { get; set; }
        public Category CategoryId { get; set; }
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Number { get; set; }
        public string Code { get; set; }
        public string ExpirationDate { get; set; }
        public string Notes { get; set; }

        public CreditCard()
        {

        }

        public bool Validate(string name, string type, string number, string notes, string code)
        {
            const string CREDIT_CARD_NUMBER_INVALID_MESSAGE = "El número debe tener 16 digitos";
            const string NOTES_LENGTH_INVALID_MESSAGE = "Las notas deben ser menos de 250 caracteres";
            const string CODE_INVALID_MESSAGE = "El código debe ser entre 3 y 4 digitos";
            const string NAME_AND_TYPE_INVALID_MESSAGE = "Debe tener entre 3 y 25 caracteres";

            const int NOTES_MAX_LENGTH = 250;
            const int CODE_TREE = 3;
            const int CODE_FOUR = 4;
            const int NAME_AND_TYPE_MAX_LENGTH = 25;
            const int NAME_AND_TYPE_MIN_LENGTH = 3;

            if ((!number.All(char.IsDigit)) || number.Length != 16)
            {
                throw new InvalidOperationException(CREDIT_CARD_NUMBER_INVALID_MESSAGE);
            }
            else if (notes.Length > NOTES_MAX_LENGTH)
            {
                throw new InvalidOperationException(NOTES_LENGTH_INVALID_MESSAGE);
            }
            else if ((!code.All(char.IsDigit)) || (code.Length != CODE_TREE && code.Length != CODE_FOUR))
            {
                throw new InvalidOperationException(CODE_INVALID_MESSAGE);
            }
            else if ((name.Length > NAME_AND_TYPE_MAX_LENGTH || name.Length < NAME_AND_TYPE_MIN_LENGTH) || (type.Length > NAME_AND_TYPE_MAX_LENGTH || type.Length < NAME_AND_TYPE_MIN_LENGTH))
            {
                throw new InvalidOperationException(NAME_AND_TYPE_INVALID_MESSAGE);
            }
            return true;
        }

        public CreditCard(string category, string name, string type, string number, string code, string expirationDate, string notes)
        {
            if (Validate(name, type, number, notes, code))
            {
                Category = category;
                Name = name;
                Type = type;
                Number = number;
                Code = code;
                ExpirationDate = expirationDate;
                Notes = notes;
            }
        }

   
        internal void Update(string newCategory, string newName, string newType, string newNumber, string newCode, string newDate, string newNotes)
        {
            if (Validate(newName, newType, newNumber, newNotes, newCode))
            {
                Category = newCategory;
                Name = newName;
                Type = newType;
                Number = newNumber;
                Code = newCode;
                ExpirationDate = newDate;
                Notes = newNotes;
            }

        }

        public override string ToString()
        {
            return "[" + this.Name + "] " + "[" + this.Type + "] " + "[" + this.Number + "]";

        }
    }
}