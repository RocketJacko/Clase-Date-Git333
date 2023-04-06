using System.Runtime.Serialization;

namespace Clase_Date.Exeptions
{
    [Serializable]
    internal class InvalidMonth : Exception
    {
        public InvalidMonth()
        {
        }

        public InvalidMonth(string? message) : base(message)
        {
        }

        public InvalidMonth(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidMonth(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}