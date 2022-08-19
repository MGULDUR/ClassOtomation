using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes
{
    public class RandomPassword
    {
        public string Create()
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder random = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int index = rnd.Next(chars.Length);
                random.Append(chars[index]);
            }

            return random.ToString();
        }
    }
}
