using Context;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EnsureDbCreated();
        }
        public void EnsureDbCreated()
        {
            try
            {
                using (var context = new EmployeeDbContext())
                {
                    context.Database.EnsureCreated();
                    MessageBox.Show($"Db is initialized");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing database: {ex.Message}");
            }
        }
    }
}
