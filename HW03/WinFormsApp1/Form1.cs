using LibraryContext;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Form1()
        {
            InitializeComponent();
            SelectData();
        }

        async void SelectData()
        {
            try
            {
                using (var db = new LibraryContextDb())
                {
                    var query1 = from b in db.Students
                                 select b;

                    comboBoxStudents.DataSource = await query1.ToListAsync();
                    comboBoxStudents.DisplayMember = "Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        async private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudents.Items.Count == 0)
                return;
            try
            {
                using (var db = new LibraryContextDb())
                {
                    List<Student>? countries = comboBoxStudents.DataSource as List<Student>;

                    if (countries == null)
                        return;

                    string student = countries[comboBoxStudents.SelectedIndex].Name;
                    var query = await (from b in db.Students
                                       where b.Name == student
                                       select b).SingleAsync();

                    textBoxName.Text = query.Name;
                    textBoxAge.Text = query.Age.ToString();
                    textBoxGroup.Text = query.IdGroupsNavigation.Name;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}
