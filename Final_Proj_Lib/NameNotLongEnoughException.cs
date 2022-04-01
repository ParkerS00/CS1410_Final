using System.Runtime.Serialization;

namespace Final_Proj_Lib
{
    [Serializable]
    internal class NameNotLongEnoughException : Exception
    {
        public NameNotLongEnoughException()
        {
        }

        public NameNotLongEnoughException(string? message) : base(message)
        {
        }

        public NameNotLongEnoughException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NameNotLongEnoughException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}