using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect
{
    public class InvoiceNumber
    {
        public string GenerateID()
        {
            string numbers = "1234567890";

            string characters = numbers;
            int length = 4;
            string id = string.Empty;
            for (int i = 0; i < length; i++)
            {
                string character = string.Empty;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                }
                while (id.IndexOf(character) != -1);
                id += character;
            }
            string InvoiceNumber = "INV" + id;
            return InvoiceNumber;
        }
    }
}
