using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр контекста базы данных с заданными параметрами
        /// </summary>
        /// <param name="options">Параметры конфигурации для DbContext</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        /// <summary>
        /// Настраивает параметры подключения к базе данных, если они не были настроены ранее
        /// </summary>
        /// <param name="optionsBuilder">Построитель параметров конфигурации</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Настройка таблицы users_roles
            modelBuilder.Entity<UserRole>()
                .ToTable("users_roles")
                .HasKey(ur => ur.Id);

            modelBuilder.Entity<UserRole>()
                .Property(ur => ur.Id)
                .HasColumnName("role_id");

            modelBuilder.Entity<UserRole>()
                .Property(ur => ur.Role)
                .HasColumnName("role");

            // Настройка таблицы Users
            modelBuilder.Entity<User>()
                .ToTable("Users")
                .HasKey(u => u.Id);

            modelBuilder.Entity<User>()
                .Property(u => u.Id)
                .HasColumnName("id");

            modelBuilder.Entity<User>()
                .Property(u => u.Login)
                .HasColumnName("login");

            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .HasColumnName("password");

            modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .HasColumnName("role");

            // Настройка таблицы Users_Courses
            modelBuilder.Entity<UserCourse>()
                .HasKey(uc => new { uc.UserId, uc.CourseId });

            modelBuilder.Entity<UserCourse>()
                .ToTable("Users_Courses")
                .Property(uc => uc.UserId)
                .HasColumnName("user_id");

            modelBuilder.Entity<UserCourse>()
                .Property(uc => uc.CourseId)
                .HasColumnName("course_id");
        }
    }
}
