using CountryModel;
using CountryModelContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
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
                using (var db = new CountryContext())
                {
                    var query1 = from b in db.Countries
                                 select b;
                    comboBoxCountries.DataSource = await query1.ToListAsync();
                    comboBoxCountries.DisplayMember = "Name";

                    var query2 = from b in db.Continents
                                select b;
                    comboBoxContitent.DataSource = await query2.ToListAsync();
                    comboBoxContitent.DisplayMember = "Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        async private void comboBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountries.Items.Count == 0)
                return;
            try
            {
                using (var db = new CountryContext())
                {
                    List<Country>? countries = comboBoxCountries.DataSource as List<Country>;
                    
                    if (countries == null)
                        return;

                    string country = countries[comboBoxCountries.SelectedIndex].Name;
                    var query = await(from b in db.Countries
                                      where b.Name == country
                                      select b).SingleAsync();

                    textBoxName.Text = query.Name;
                    textBoxCapital.Text = query.Capital;
                    textBoxPopulation.Text = query.Population.ToString();
                    textBoxArea.Text = query.Area.ToString();

                    foreach (Continent continent in comboBoxContitent.Items)
                    {
                        if (continent.Id == query.Continent.Id)
                        {
                            comboBoxContitent.SelectedItem = continent;
                            break;
                        }
                        else
                        {
                            comboBoxContitent.SelectedItem = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        async private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text.Trim(),
                       capital = textBoxCapital.Text.Trim();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(capital))
                {
                    throw new Exception("Text box should have text");
                }

                if (!int.TryParse(textBoxPopulation.Text, out int population))
                {
                    throw new Exception("Text box should be number");
                }

                if (!int.TryParse(textBoxArea.Text, out int area))
                {
                    throw new Exception("Text box should be number");
                }

                Continent? selectedContinent = comboBoxContitent.SelectedItem as Continent;
                if (selectedContinent == null)
                {
                    throw new Exception("Continent should be selected");
                }

                using (var db = new CountryContext())
                {
                    var continent = await db.Continents.FindAsync(selectedContinent.Id);
                    if (continent == null)
                    {
                        throw new Exception("Selected continent not found in database");
                    }

                    var country = new Country
                    {
                        Name = name,
                        Capital = capital,
                        Population = population,
                        Area = area,
                        Continent = continent
                    };

                    await db.Countries.AddAsync(country);
                    await db.SaveChangesAsync();

                    ShowInfo("Country added");
                    SelectData();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        async private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxCountries.Items.Count == 0)
                return;
            try
            {
                using (var db = new CountryContext())
                {
                    List<Country>? list = comboBoxCountries.DataSource as List<Country>;
                    string student = list[comboBoxCountries.SelectedIndex].Name;
                    var query = from b in db.Countries
                                where b.Name == student
                                select b;
                    db.Countries.RemoveRange(query);
                    await db.SaveChangesAsync();

                    var query2 = from b in db.Countries
                                 select b;
                    comboBoxCountries.DataSource = await query2.ToListAsync();
                    comboBoxCountries.DisplayMember = "Name";

                    ShowInfo("Country deleted from the list");
                    SelectData();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        async private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text.Trim(),
                       capital = textBoxCapital.Text.Trim();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(capital))
                {
                    throw new Exception("Text box should have text");
                }

                if (!int.TryParse(textBoxPopulation.Text, out int population))
                {
                    throw new Exception("Text box should be number");
                }

                if (!int.TryParse(textBoxArea.Text, out int area))
                {
                    throw new Exception("Text box should be number");
                }

                Continent? selectedContinent = comboBoxContitent.SelectedItem as Continent;
                if (selectedContinent == null)
                {
                    throw new Exception("Continent should be selected");
                }

                using (var db = new CountryContext())
                {
                    List<Continent>? list = comboBoxContitent.DataSource as List<Continent>;
                    string continent = list[comboBoxContitent.SelectedIndex].Name;
                    var query = await (from b in db.Continents
                                       where b.Name == continent
                                       select b).SingleAsync();
                    if (query == null)
                        return;

                    List<Country>? studentlist = comboBoxCountries.DataSource as List<Country>;
                    string country = studentlist[comboBoxCountries.SelectedIndex].Name;
                    var query2 = await (from b in db.Countries
                                        where b.Name == country
                                        select b).SingleAsync();

                    query2.Name = name;
                    query2.Capital = capital;
                    query2.Population = population;
                    query2.Area = area;
                    query2.Continent = query;
                    await db.SaveChangesAsync();

                    ShowInfo("Data about country changed");
                    SelectData();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}
