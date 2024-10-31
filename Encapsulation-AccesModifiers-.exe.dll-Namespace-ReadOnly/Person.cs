using System;
namespace Encapsulation_AccesModifiers_.exe.dll_Namespace_ReadOnly
{
    public class Person
    {

        private string _name;
        private string _surname;
        private byte _age;
        public byte Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age must be more than 0");
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (CorrectData(value) && NameLength(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Invalid Name");
                }
            }
        }



        public string Surname
        {
            get { return _surname; }
            set
            {
                if (CorrectData(value) && SurnameLength(value))
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Invalid Surname.");
                }
            }
        }



        public bool CorrectData(string data)
        {
            bool isCorrect = false;
            if (string.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Enter value");
                return false;
            }
            if (char.IsUpper(data[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool NameLength(string name)
        {
            bool isCorrect = false;
            if (name.Length >= 3 && name.Length <= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SurnameLength(string surname)
        {
            bool isCorrect = false;
            if (surname.Length >= 3 && surname.Length <= 35)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Person(string name, string surname, byte age)
        {
            Name = name;
            Age = age;
            Surname = surname;
        }

        public Person()
        {

        }
    }







}

