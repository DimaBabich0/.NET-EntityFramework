using Microsoft.EntityFrameworkCore;

namespace App
{
    public partial class Form1 : Form
    {
        private Dictionary<int, string> optionsDictionary = new Dictionary<int, string>
        {
            { (int)Display.Subjects, "Subjects" },
            { (int)Display.Teachers, "Teachers" },
            { (int)Display.Curators, "Curators" },
            { (int)Display.Faculties, "Faculties" },
            { (int)Display.Departments, "Departments" },
            { (int)Display.Groups, "Groups" },
        };
        public enum Display
        {
            Subjects = 1,
            Teachers = 2,
            Curators = 3,
            Faculties = 4,
            Departments = 5,
            Groups = 6,
        }
        
        public Form1()
        {
            InitializeComponent();
            CheckConnection();
            InitializeComboBoxSearchOptions();
        }
        public void CheckConnection()
        {
            try
            {
                using (var context = new AcademyDbContext())
                {
                    context.Database.EnsureCreated();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing database: {ex.Message}");
            }
        }
        public void InitializeComboBoxSearchOptions()
        {
            foreach (var option in optionsDictionary)
            {
                comboBoxOptions.Items.Add(option.Value);
            }
            comboBoxOptions.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int selectedId = comboBoxOptions.SelectedIndex + 1;
            if (Enum.IsDefined(typeof(Display), selectedId))
            {
                Display option = (Display)selectedId;
                switch (option)
                {
                    case Display.Subjects:
                        DisplaySubjects();
                        break;
                    case Display.Teachers:
                        DisplayTeachers();
                        break;
                    case Display.Curators:
                        DisplayCurators();
                        break;
                    case Display.Faculties:
                        DisplayFaculties();
                        break;
                    case Display.Departments:
                        DisplayDepartments();
                        break;
                    case Display.Groups:
                        DisplayGroups();
                        break;
                    default:
                        MessageBox.Show("Invalid selection");
                        break;
                }
            }
        }
        private void DisplaySubjects()
        {
            listViewData.Columns.Clear();
            listViewData.Columns.Add("Id", 50);
            listViewData.Columns.Add("Name", -2);

            listViewData.Items.Clear();
            using (var context = new AcademyDbContext())
            {
                var subjects = context.Subjects.ToList();

                foreach (var subject in subjects)
                {
                    var item = new ListViewItem(subject.Id.ToString());
                    item.SubItems.Add(subject.Name);

                    listViewData.Items.Add(item);
                }
            }
        }
        private void DisplayTeachers()
        {
            listViewData.Columns.Clear();
            listViewData.Columns.Add("Id", 50);
            listViewData.Columns.Add("Name", 150);
            listViewData.Columns.Add("Surname", 150);
            listViewData.Columns.Add("Salary", -2);

            listViewData.Items.Clear();
            using (var context = new AcademyDbContext())
            {
                var teachers = context.Teachers.ToList();
                foreach (var teacher in teachers)
                {
                    var item = new ListViewItem(teacher.Id.ToString());
                    item.SubItems.Add(teacher.Name);
                    item.SubItems.Add(teacher.Surname);
                    item.SubItems.Add(teacher.Salary.ToString());

                    listViewData.Items.Add(item);
                }
            }
        }
        private void DisplayCurators()
        {
            listViewData.Columns.Clear();
            listViewData.Columns.Add("Id", 50);
            listViewData.Columns.Add("Name", 150);
            listViewData.Columns.Add("Surname", -2);

            listViewData.Items.Clear();
            using (var context = new AcademyDbContext())
            {
                var curators = context.Curators.ToList();
                foreach (var curator in curators)
                {
                    var item = new ListViewItem(curator.Id.ToString());
                    item.SubItems.Add(curator.Name);
                    item.SubItems.Add(curator.Surname);

                    listViewData.Items.Add(item);
                }
            }
        }
        private void DisplayFaculties()
        {
            listViewData.Columns.Clear();
            listViewData.Columns.Add("Id", 50);
            listViewData.Columns.Add("Name", 200);
            listViewData.Columns.Add("Financing", -2);

            listViewData.Items.Clear();
            using (var context = new AcademyDbContext())
            {
                var faculties = context.Faculties.ToList();
                foreach (var faculty in faculties)
                {
                    var item = new ListViewItem(faculty.Id.ToString());
                    item.SubItems.Add(faculty.Name);
                    item.SubItems.Add(faculty.Financing.ToString("C"));

                    listViewData.Items.Add(item);
                }
            }
        }
        private void DisplayDepartments()
        {
            listViewData.Columns.Clear();
            listViewData.Columns.Add("Id", 50);
            listViewData.Columns.Add("Name", 250);
            listViewData.Columns.Add("Financing", 150);
            listViewData.Columns.Add("Faculty", -2);
            
            listViewData.Items.Clear();
            using (var context = new AcademyDbContext())
            {
                var departments = context.Departments.Include(d => d.Faculty).ToList();

                foreach (var department in departments)
                {
                    var item = new ListViewItem(department.Id.ToString());
                    item.SubItems.Add(department.Name);
                    item.SubItems.Add(department.Financing.ToString("C"));
                    item.SubItems.Add(department.Faculty?.Name ?? "Unknown");

                    listViewData.Items.Add(item);
                }
            }
        }
        private void DisplayGroups()
        {
            listViewData.Columns.Clear();
            listViewData.Columns.Add("Id", 50);
            listViewData.Columns.Add("Name", 100);
            listViewData.Columns.Add("Year", 50);
            listViewData.Columns.Add("Department", -2);

            listViewData.Items.Clear();
            using (var context = new AcademyDbContext())
            {
                var groups = context.Groups.Include(g => g.Department).ToList();

                foreach (var group in groups)
                {
                    var item = new ListViewItem(group.Id.ToString());
                    item.SubItems.Add(group.Name);
                    item.SubItems.Add(group.Year.ToString());
                    item.SubItems.Add(group.Department?.Name ?? "Unknown");

                    listViewData.Items.Add(item);
                }
            }
        }
    }
}
