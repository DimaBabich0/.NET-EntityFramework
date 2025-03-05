using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model;

namespace Context
{
    public class EmployeeDbContext : DbContext
    {
        static DbContextOptions<EmployeeDbContext> _options;
        static EmployeeDbContext()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<EmployeeDbContext>();
            _options = optionsBuilder.UseSqlServer(connectionString).Options;
        }

        public EmployeeDbContext() : base(_options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Ocupation> Ocupations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ocupation>(entity =>
            {
                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(p => p.Title)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(e => e.Ocupation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(e => e.OcupationId);


                entity.Property(e => e.Salary)
                    .IsRequired()
                    .HasDefaultValue(1);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);

                entity.Property(u => u.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(u => u.Login)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(u => u.Password)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ocupation>().HasData(
                new Ocupation { Id = 1, Title = "Programmer" },
                new Ocupation { Id = 2, Title = "Designer" },
                new Ocupation { Id = 3, Title = "Analyst" },
                new Ocupation { Id = 4, Title = "Tester" },
                new Ocupation { Id = 5, Title = "Administrator" }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Daniel", Surname = "Lewis", OcupationId = 4, Salary = 2000},
                new Employee { Id = 2, Name = "Sophia", Surname = "Walker", OcupationId = 1, Salary = 3500 },
                new Employee { Id = 3, Name = "Michael", Surname = "Clark", OcupationId = 3, Salary = 4300 },
                new Employee { Id = 4, Name = "Emily", Surname = "Rodriguez", OcupationId = 5, Salary = 5100 },
                new Employee { Id = 5, Name = "James", Surname = "Hall", OcupationId = 2, Salary = 2700 },
                new Employee { Id = 6, Name = "Mia", Surname = "Scott", OcupationId = 4, Salary = 2500 },
                new Employee { Id = 7, Name = "Benjamin", Surname = "Allen", OcupationId = 1, Salary = 3200 },
                new Employee { Id = 8, Name = "Charlotte", Surname = "King", OcupationId = 2, Salary = 4800 },
                new Employee { Id = 9, Name = "Alexander", Surname = "Wright", OcupationId = 3, Salary = 3900 },
                new Employee { Id = 10, Name = "Isabella", Surname = "Young", OcupationId = 5, Salary = 5600 }
            );

            modelBuilder.Entity<User>().HasData(
                    new User { Id = 1, Login = "admin", Password = "admin" }
                );
        }
    }
}
