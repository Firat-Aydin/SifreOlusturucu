using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifreOlusturucu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sifre uzunluğunu girin :");
            int passwordLength = int.Parse(Console.ReadLine());

            string password = GeneratePassword(passwordLength);
            Console.WriteLine("Oluşturulan şifre: " + password);

            Console.Read();
        }

        static string GeneratePassword(int length)
        {
            const string chars =
                "ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghıjklmnopqrstuwxyz0123456789!@#$%^&*()_*";
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
    }
}
