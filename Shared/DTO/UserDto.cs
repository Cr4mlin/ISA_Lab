namespace Shared.DTO
{
    /// <summary>
    /// DTO для передачи информации о пользователе между слоями
    /// </summary>
    public class UserDto
    {
        public int Id { get; set; }
        public string Login { get; set; } = string.Empty;
        public string NickName { get; set; } = string.Empty;
        public int Role { get; set; }
    }
}
