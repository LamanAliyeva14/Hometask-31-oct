using System;
namespace Encapsulation_AccesModifiers_.exe.dll_Namespace_ReadOnly
{
    public class User
    {
        public string Username { get; set; }
        private string _password;
        private byte _age;
        public byte Age
        {
            get { return _age; }
            set
            {
                if (CorrectAge(value))
                {
                    _age = value;
                }

            }

        }

        private bool CorrectAge(byte ageinput)
        {
            bool isOkay = false;
            if (ageinput <= 0)
            {
                Console.WriteLine("Enter correct value");
                return isOkay;
            }
            else
            {
                isOkay = true;
            }
            return isOkay;

        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (CheckPassword(value) && CheckUpperCase(value) & CheckDigit(value))
                {
                    _password = value;
                    Console.WriteLine("Password was set succesfully");
                }
                else
                    Console.WriteLine("Password was not set");
            }
        }

        private bool CheckPassword(string pass)
        {
            bool isOkay = false;
            if (string.IsNullOrWhiteSpace(pass))
            {
                Console.WriteLine("Enter a value");
                return false;
            }

            if (pass.Length < 8)
            {
                Console.WriteLine("Enter more than 8 values");
                return false;
            }
            return true;
        }


        private bool CheckUpperCase(string pass)
        {
            bool hasUpperCase = false;
            foreach (char c in pass)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }
            Console.WriteLine("Password must containt at least one UpperCase");
            return false;


        }

        private bool CheckDigit(string pass)
        {
            bool hasDigit = false;
            foreach (char c in pass)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            Console.WriteLine("Password must containt at least one Digit");
            return false;

        }
    }
}

