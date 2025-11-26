using System;

namespace Logic.Exceptions
{
    /// <summary>
    /// Исключение, возникающее при ошибке поиска
    /// </summary>
    public class SearchException : Exception
    {
        public SearchException(string message) : base(message) { }

        public SearchException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
