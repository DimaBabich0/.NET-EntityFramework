using Context;
using Microsoft.EntityFrameworkCore;
using Model;
using System.Xml.Linq;

namespace WinFormsApp
{
    public partial class Manager : Form
    {
        private static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Logger logger = new Logger();

        public enum Display
        {
            ByName = 1,
            BySurmame = 2,
            ByOcupation = 3,
        }
        private Dictionary<int, string> optionsDictionary = new Dictionary<int, string>
        {
            { (int)Display.ByName, "Name" },
            { (int)Display.BySurmame, "Surname" },
            { (int)Display.ByOcupation, "Ocupation" },
        };

        public Manager()
        {
            InitializeComponent();
            EnsureDbCreated();
            InitializeSearchOptions();
            DisplayAllEmployees();
        }
        public void EnsureDbCreated()
        {
            try
            {
                using (var context = new EmployeeDbContext())
                {
                    context.Database.EnsureCreated();
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error initializing database: {ex.Message}");
            }
        }
        public void InitializeSearchOptions()
        {
            foreach (var option in optionsDictionary)
            {
                comboBoxSearchOption.Items.Add(option.Value);
            }
            comboBoxSearchOption.SelectedIndex = 0;
        }
        private void DisplayAllEmployees()
        {
            listViewData.Columns.Clear();
            listViewData.Columns.Add("Id", 30);
            listViewData.Columns.Add("Name", 80);
            listViewData.Columns.Add("Surname", 100);
            listViewData.Columns.Add("Ocupation", 150);
            listViewData.Columns.Add("Salary", -2);
            
            listViewData.Items.Clear();
            using (var context = new EmployeeDbContext())
            {
                var employees = context.Employees.Include(e => e.Ocupation).ToList();

                foreach (var employee in employees)
                {
                    AddItem(employee);
                }
            }

            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxOcupation.Text = "";
            textBoxSalary.Text = "";
            buttonDelete.Enabled = false;
            return;
        }

        public void AddItem(Employee employee)
        {
            var item = new ListViewItem(employee.Id.ToString());
            item.SubItems.Add(employee.Name);
            item.SubItems.Add(employee.Surname);
            item.SubItems.Add(employee.Ocupation.Title);
            item.SubItems.Add(employee.Salary.ToString());
            listViewData.Items.Add(item);
        }

        private void listViewData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewData.SelectedItems.Count == 0)
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxOcupation.Text = "";
                textBoxSalary.Text = "";
                buttonDelete.Enabled = false;
                return;
            }
            
            var item = listViewData.SelectedItems[0];
            textBoxName.Text = item.SubItems[1].Text;
            textBoxSurname.Text = item.SubItems[2].Text;
            textBoxOcupation.Text = item.SubItems[3].Text;
            textBoxSalary.Text = item.SubItems[4].Text;
            buttonDelete.Enabled = true;
        }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int selectedId = comboBoxSearchOption.SelectedIndex + 1;
            if (Enum.IsDefined(typeof(Display), selectedId))
            {
                string text = textBoxSearch.Text.Trim();
                if (string.IsNullOrEmpty(text))
                {
                    DisplayAllEmployees();
                    return;
                }    

                Display option = (Display)selectedId;
                string criteria = optionsDictionary[selectedId];
                logger.LogSearched(criteria, text);
                switch (option)
                {
                    case Display.ByName:
                        DisplayByName(text);
                        break;
                    case Display.BySurmame:
                        DisplayBySurname(text);
                        break;
                    case Display.ByOcupation:
                        DisplayByOcupation(text);
                        break;
                    default:
                        ShowError("Invalid selection");
                        break;
                }
            }
        }
        private void DisplayByName(string name)
        {
            listViewData.Items.Clear();

            using (var context = new EmployeeDbContext())
            {
                var employees = context.Employees
                    .Include(e => e.Ocupation)
                    .Where(e => e.Name.Contains(name))
                    .ToList();

                foreach (var employee in employees)
                {
                    AddItem(employee);
                }
            }
        }
        private void DisplayBySurname(string surname)
        {
            listViewData.Items.Clear();

            using (var context = new EmployeeDbContext())
            {
                var employees = context.Employees
                    .Include(e => e.Ocupation)
                    .Where(e => e.Surname.Contains(surname))
                    .ToList();

                foreach (var employee in employees)
                {
                    AddItem(employee);
                }
            }
        }
        private void DisplayByOcupation(string ocupation)
        {
            listViewData.Items.Clear();

            using (var context = new EmployeeDbContext())
            {
                var employees = context.Employees
                    .Include(e => e.Ocupation)
                    .Where(e => e.Ocupation.Title.Contains(ocupation))
                    .ToList();

                foreach (var employee in employees)
                {
                    AddItem(employee);
                }
            }
        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim(),
                   surname = textBoxSurname.Text.Trim(),
                   ocupation = textBoxOcupation.Text.Trim();

            foreach (var str in new[] { name, surname, ocupation })
            {
                if (string.IsNullOrEmpty(str))
                    ShowError("Fill in all fields");
            }

            if (!int.TryParse(textBoxSalary.Text.Trim(), out int salary))
                ShowError("Field with salary should be number");

            Ocupation ocupationDb;
            using (var context = new EmployeeDbContext())
            {
                ocupationDb = context.Ocupations.FirstOrDefault(p => p.Title == ocupation);
                if (ocupation == null)
                {
                    ShowError("Position not found");
                    return;
                }

                Employee employee = new Employee
                {
                    OcupationId = ocupationDb.Id,
                    Name = name,
                    Surname = surname,
                    Salary = salary
                };

                context.Employees.Add(employee);
                context.SaveChanges();
                logger.LogAdded(name, surname);
            }
            DisplayAllEmployees();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewData.SelectedItems.Count == 0)
            {
                ShowError("Choose item from list");
                return;
            }

            using (var context = new EmployeeDbContext())
            {
                int id = int.Parse(listViewData.SelectedItems[0].Text);
                var employee = context.Employees.Find(id);

                if (employee != null)
                {
                    context.Employees.Remove(employee);
                    context.SaveChanges();
                    logger.LogDeleted(employee.Name, employee.Surname);
                }
                else
                {
                    ShowError("Employee not found");
                }
            }
            DisplayAllEmployees();
        }
    }
}
