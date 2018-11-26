using System;

namespace MiniMax
{
    public class InvalidCoordinateException : Exception
    {
        public InvalidCoordinateException(string message) : base(message)
        {
        }
    }
}