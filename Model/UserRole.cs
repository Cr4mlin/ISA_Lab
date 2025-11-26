namespace Model
{
    public class UserRole : IDomainObject
    {
        public int Id { get; set; }
        public string Role { get; set; } = string.Empty;
    }
}
