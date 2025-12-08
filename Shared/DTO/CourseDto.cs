namespace Shared.DTO
{
    /// <summary>
    /// DTO для передачи информации о курсе между слоями
    /// </summary>
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public string TeacherName { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
