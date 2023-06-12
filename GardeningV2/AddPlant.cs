using Gardening;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardeningV2
{
    public partial class AddPlant : Form
    {
        private GardenModel garden;
        private CustomerModel customer;
        private PlantModel plant;

        public AddPlant(GardenModel garden, CustomerModel customer)
        {
            InitializeComponent();
            this.garden = garden;
            this.customer = customer;

            plantColorComboBox.DataSource = Enum.GetValues(typeof(Gardening.Color));
        }

        private void addPlantButton_Click(object sender, EventArgs e)
        {
            if (garden == null)
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
            plant = new PlantModel(
                plantNameTextBox.Text.ToString(),
                color,
                plantTypeTextBox.Text,
                pruneStart,
                pruneEnd,
                blossomStart,
                blossomEnd
            );

            garden.AddPlant(plant);
            Dashboard dashboardForm = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboardForm != null)
            {
                dashboardForm.UpdatePlantList(plant);
            }

            SaveDataToJSON();

            this.Close();
        }

        private void SaveDataToJSON()
        {
            string customerJson = File.ReadAllText("customer.json");
            customer = JsonConvert.DeserializeObject<CustomerModel>(customerJson);

            garden = customer?.Gardens.FirstOrDefault();

            if (garden != null)
            {
                garden.AddPlant(plant);
            }
            else
            {
                garden = new GardenModel("Your Garden Name");
                garden.AddPlant(plant);
                customer?.AddGarden(garden);
            }

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            string updatedCustomerJson = JsonConvert.SerializeObject(customer, settings);
            File.WriteAllText("customer.json", updatedCustomerJson);
        }
    }
}
