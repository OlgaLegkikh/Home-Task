using System;
using System.Runtime.Serialization;

namespace Task_7_1
{
    [Serializable]
    internal class InvalidMoverException : Exception
    {
        public InvalidMoverException()
        {
        }

        public InvalidMoverException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

    }
}