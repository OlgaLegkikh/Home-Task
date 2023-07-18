using System;
using System.Runtime.Serialization;

namespace Task_7_1
{
    [Serializable]
    internal class InvalidBoardParametrException : Exception
    {
        public InvalidBoardParametrException()
        {
        }

        public InvalidBoardParametrException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

    }
}