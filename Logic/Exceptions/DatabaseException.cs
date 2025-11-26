using System;

namespace Logic.Exceptions
{
    /// <summary>
    /// Исключение, возникающее при ошибках работы с базой данных
    /// </summary>
    public class DatabaseException : Exception
    {
        public DatabaseException(string message) : base(message) { }

        public DatabaseException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
