namespace Model
{
    public class User : IDomainObject
    {
        public int Id { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int Role { get; set; }
        public string NickName { get; set; } = string.Empty;
    }
}
