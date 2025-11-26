using System;

namespace Logic.Exceptions
{
    /// <summary>
    /// Исключение, возникающее при ошибке фильтрации данных
    /// </summary>
    public class FilterException : Exception
    {
        public FilterException(string message) : base(message) { }

        public FilterException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
