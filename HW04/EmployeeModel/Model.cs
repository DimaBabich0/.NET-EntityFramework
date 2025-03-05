namespace Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int OcupationId { get; set; }
        public virtual Ocupation Ocupation { get; set; }
        public int Salary { get; set; }
    }

    public class Ocupation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
