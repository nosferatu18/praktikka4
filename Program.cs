using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikka4
{
    using System;

    class Program
    {
        static bool CheckLength(string password)
        {
            if (password.Length >= 8)
                return true;
            else
                return false;
        }

        static bool CheckDigit(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                    return true;
            }
            return false;
        }

        static bool CheckUpper(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'A' && password[i] <= 'Z')
                    return true;
            }
            return false;
        }

        static bool IsPasswordStrong(string password)
        {
            if (CheckLength(password) && CheckDigit(password) && CheckUpper(password))
                return true;
            else
                return false;
        }

        static void PrintPasswordReport(string password)
        {
            Console.WriteLine("Проверка пароля:");
            Console.WriteLine("Длина >= 8: " + CheckLength(password));
            Console.WriteLine("Есть цифра: " + CheckDigit(password));
            Console.WriteLine("Есть заглавная буква: " + CheckUpper(password));
            Console.WriteLine();

            if (IsPasswordStrong(password))
                Console.WriteLine("Пароль подходит");
            else
                Console.WriteLine("Пароль НЕ подходит");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();
            PrintPasswordReport(password);
        }
    }
}

