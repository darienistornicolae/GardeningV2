using Gardening;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardeningV2
{
    public partial class AddGarden : Form
    {
        private CustomerModel customer;
        private GardenModel newGarden;

        public AddGarden(CustomerModel customer)
        {
            InitializeComponent();
            this.customer = customer;
            plantColorComboBox.DataSource = Enum.GetValues(typeof(Gardening.Color));
        }

        private void AddGarden_Load(object sender, EventArgs e)
        {
            // Deserialize customer data from JSON
            string customerJson = File.ReadAllText("customer.json");
            customer = JsonConvert.DeserializeObject<CustomerModel>(customerJson);
        }

        private void addNewGardenButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addNewGardenTextBox.Text))
            {
                MessageBox.Show("Please enter a garden name.");
                return;
            }

            // Create a new garden with the entered name
            newGarden = new GardenModel(addNewGardenTextBox.Text);
            customer.AddGarden(newGarden);

            // Save updated customer to the JSON file
            SaveDataToJSON();

            MessageBox.Show("Garden added successfully!");
        }

        private void addPlantButton_Click(object sender, EventArgs e)
        {
            if (newGarden == null)
            {
                MessageBox.Show("Please create a garden first.");
                return;
            }

            if (string.IsNullOrEmpty(plantNameTextBox.Text) || string.IsNullOrEmpty(plantTypeTextBox.Text) || plantColorComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please enter all the plant details.");
                return;
            }

            DateTime pruneStart = pruneStartPeriodTimePicker.Value;
            DateTime pruneEnd = pruneEndTimePicker.Value;
            DateTime blossomStart = blossomStartTimePicker.Value;
            DateTime blossomEnd = blossomEndTimerPeriod.Value;

            if (pruneStart > pruneEnd || blossomStart > blossomEnd)
            {
                MessageBox.Show("Please select valid periods.");
                return;
            }

            Gardening.Color color = (Gardening.Color)plantColorComboBox.SelectedItem;
            PlantModel plant = new PlantModel(
                plantNameTextBox.Text,
                color,
                plantTypeTextBox.Text,
                pruneStart,
                pruneEnd,
                blossomStart,
                blossomEnd
            );

            newGarden.AddPlant(plant);
            plantsListBox.Items.Add(plant);

            // Save updated garden to the JSON file
            SaveDataToJSON();

            ClearPlantFields();
        }

        private void SaveDataToJSON()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            // Serialize the customer data back to JSON
            string updatedCustomerJson = JsonConvert.SerializeObject(customer, settings);
            File.WriteAllText("customer.json", updatedCustomerJson);
        }

        private void ClearPlantFields()
        {
            plantNameTextBox.Text = string.Empty;
            plantTypeTextBox.Text = string.Empty;
            plantColorComboBox.SelectedItem = null;
            pruneStartPeriodTimePicker.Value = DateTime.Now;
            pruneEndTimePicker.Value = DateTime.Now;
            blossomStartTimePicker.Value = DateTime.Now;
            blossomEndTimerPeriod.Value = DateTime.Now;
        }

        private void goToDashboardButton_Click(object sender, EventArgs e)
        {
            // Close the AddGarden form
            this.Close();

            // Create an instance of the Dashboard form
            Dashboard dashboardForm = new Dashboard();

            // Show the Dashboard form
            dashboardForm.Show();
        }

    }
}
