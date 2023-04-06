using System.Runtime.Serialization;

namespace Clase_Date.Exeptions
{
    [Serializable]
    internal class InvalidDay : Exception
    {
        public InvalidDay()
        {
        }

        public InvalidDay(string? message) : base(message)
        {
        }

        public InvalidDay(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidDay(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}