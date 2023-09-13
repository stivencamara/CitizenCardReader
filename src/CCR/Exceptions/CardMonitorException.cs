using System;

namespace CCR.Exceptions
{
    public class CardMonitorException : Exception
    {
        public CardMonitorException(string message) : base(message) { }
        public CardMonitorException(Exception exception) : base(exception.Message, exception.InnerException) { }
    }
}
