namespace Logic.Exceptions
{
    public class CourseAlreadyPurchasedException : Exception
    {
        public CourseAlreadyPurchasedException(string message) : base(message)
        {
        }
    }
}
