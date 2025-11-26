using System;

namespace Logic.Exceptions
{
    /// <summary>
    /// Исключение, возникающее при ошибке загрузки данных
    /// </summary>
    public class DataLoadException : Exception
    {
        public DataLoadException(string message) : base(message) { }

        public DataLoadException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
