
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Category
    {
        const string INVALID_CATEGORY_LENGTH_MESSAGE = "El nombre de la categoría debe tener entre 3 y 15 caracteres";
        public int Id { get; set; }

        public User User { get; set; }
        public string Name { get; set; }

        public Category()
        {

        }

        public Category(string name)
        {
            if (Validate(name))
            {
                Name = name;
            }
        }

        private bool Validate(string categoryName)
        {
            if (!(categoryName.Length > 2 && categoryName.Length < 16))
            {
                throw new InvalidOperationException(INVALID_CATEGORY_LENGTH_MESSAGE);
            }
            return true;
        }

  
        public override string ToString()
        {
            return this.Name;
        }
    }
}