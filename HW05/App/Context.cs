using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class AcademyDbContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Curator> Curators { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupsLectures> GroupsLectures { get; set; }
        public DbSet<GroupsCurators> GroupsCurators { get; set; }

        static DbContextOptions<AcademyDbContext> _options;
        static AcademyDbContext()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<AcademyDbContext>();
            _options = optionsBuilder.UseSqlServer(connectionString).Options;
        }
        public AcademyDbContext() : base(_options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "Mathematics" },
                new Subject { Id = 2, Name = "Physics" }
            );

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, Name = "Callan", Surname = "Wickham", Salary = 30000 },
                new Teacher { Id = 2, Name = "Fleurette", Surname = "Cornett", Salary = 35000 }
            );

            modelBuilder.Entity<Curator>().HasData(
                new Curator { Id = 1, Name = "Sammi", Surname = "Batts" },
                new Curator { Id = 2, Name = "Bianca", Surname = "Symonds" }
            );

            modelBuilder.Entity<Faculty>().HasData(
                new Faculty { Id = 1, Name = "Engineering", Financing = 150000 },
                new Faculty { Id = 2, Name = "Science", Financing = 250000 }
            );

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Computer Science", Financing = 400000, FacultyId = 1 },
                new Department { Id = 2, Name = "Astronomy and Space Physics", Financing = 500000, FacultyId = 2 }
            );

            modelBuilder.Entity<Group>().HasData(
                new Group { Id = 1, Name = "AB-101", Year = 1, DepartmentId = 1 },
                new Group { Id = 2, Name = "AB-102", Year = 1, DepartmentId = 2 }
            );

            modelBuilder.Entity<Lecture>().HasData(
                new Lecture { Id = 1, LectureRoom = "101", SubjectId = 1, TeacherId = 1 },
                new Lecture { Id = 2, LectureRoom = "102", SubjectId = 2, TeacherId = 2 }
            );

            modelBuilder.Entity<GroupsLectures>().HasData(
                new GroupsLectures { Id = 1, GroupId = 1, LectureId = 1 },
                new GroupsLectures { Id = 2, GroupId = 2, LectureId = 2 }
            );

            modelBuilder.Entity<GroupsCurators>().HasData(
                new GroupsCurators { Id = 1, GroupId = 1, CuratorId = 1 },
                new GroupsCurators { Id = 2, GroupId = 2, CuratorId = 2 }
            );
        }
    }
}
