using System;
using System.Text.RegularExpressions;

namespace Task_7_1
{
    class User
    {
        public string UserName { get; set; }

        public User()
        {
            
            UserName = AskUserName();
        }

        private string AskUserName()
        {
            Console.WriteLine("Представьтесь пожалуйста!");
            try
            {
                string name = Console.ReadLine();
                ValidateUserName(name);
                return name;
            }
            catch (InvalidUserNameException)
            {
                return AskUserName();
            }
        }

        private static void ValidateUserName(string name)
        {
            Regex regex = new Regex("^[а-яА-Я]+$");
            if (!regex.IsMatch(name))
            {
                throw new InvalidUserNameException(String.Format("Некорреткное имя пользователя: {0}", name));
            }

        }
    }

    [Serializable]
    class InvalidUserNameException : Exception
    {
        public InvalidUserNameException() { }

        public InvalidUserNameException(string message)
            : base(message)
        {
            Console.WriteLine(message);
        }
    }

}
