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
    public partial class Dashboard : Form
    {
        private CustomerModel customer;
        private GardenModel garden;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Deserialize customer data from JSON
            string customerJson = File.ReadAllText("customer.json");
            customer = JsonConvert.DeserializeObject<CustomerModel>(customerJson);

            // Get the first garden from the customer (assuming only one garden is supported in this example)
            garden = customer?.Gardens.FirstOrDefault();

            if (garden != null)
            {
                gardenNameLabel.Text = garden.GardenName;

                // Clear existing items in the ListBox
                plantsListTextBox.Items.Clear();

                // Populate ListBox with plant names
                foreach (PlantModel plant in garden.PlantsInGarden)
                {
                    plantsListTextBox.Items.Add(plant.Plant);
                }

                // Display details of the first plant (assuming at least one plant exists in the garden)
                if (garden.PlantsInGarden.Count > 0)
                {
                    // Select the first plant by default
                    plantsListTextBox.SelectedIndex = 0;

                    PlantModel selectedPlant = garden.PlantsInGarden[plantsListTextBox.SelectedIndex];
                    UpdatePlantDetails(selectedPlant);
                }
            }
        }
        private void UpdatePlantDetails(PlantModel plant)
        {
            plantNameLabel.Text = plant.Plant;
            plantTypeLabel.Text = plant.Type;
            BlossomPeriodLabel.Text = $"{plant.StartBlossomPeriod.ToShortDateString()} - {plant.EndBlosomPeriod.ToShortDateString()}";
            prunePeriodLabel.Text = $"{plant.StartPrunePeriods.ToShortDateString()} - {plant.EndPrunePeriods.ToShortDateString()}";
            plantColorLabel.Text = plant.Color.ToString();
        }
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            // Check if a plant is selected in the ListBox
            if (plantsListTextBox.SelectedItem != null)
            {
                // Get the selected plant from the ListBox
                PlantModel selectedPlant = garden.PlantsInGarden[plantsListTextBox.SelectedIndex];

                // Update the labels with the selected plant's information
                plantNameLabel.Text = selectedPlant.Plant;
                plantTypeLabel.Text = selectedPlant.Type;
                BlossomPeriodLabel.Text = $"{selectedPlant.StartBlossomPeriod.ToShortDateString()} - {selectedPlant.EndBlosomPeriod.ToShortDateString()}";
                prunePeriodLabel.Text = $"{selectedPlant.StartPrunePeriods.ToShortDateString()} - {selectedPlant.EndPrunePeriods.ToShortDateString()}";
                plantColorLabel.Text = selectedPlant.Color.ToString();
            }
        }


        private void addPlantButton_Click(object sender, EventArgs e)
        {
            AddPlant addPlantForm = new AddPlant(garden, customer);
            addPlantForm.Show();
        }

        private void removePlantButton_Click(object sender, EventArgs e)
        {
            if (plantsListTextBox.SelectedItem != null)
            {
                PlantModel selectedPlant = garden.PlantsInGarden[plantsListTextBox.SelectedIndex];

                garden.DeletePlant(selectedPlant);
                plantsListTextBox.Items.RemoveAt(plantsListTextBox.SelectedIndex);

                SaveDataToJSON();
                ClearPlantDetails();
            }
            else
            {
                MessageBox.Show("Please select a plant from the list.");
            }
        }

        private void ClearPlantDetails()
        {
            plantNameLabel.Text = string.Empty;
            plantTypeLabel.Text = string.Empty;
            BlossomPeriodLabel.Text = string.Empty;
            prunePeriodLabel.Text = string.Empty;
            plantColorLabel.Text = string.Empty;
        }

        private void SaveDataToJSON()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
            string updatedCustomerJson = JsonConvert.SerializeObject(customer, settings);
            File.WriteAllText("customer.json", updatedCustomerJson);
        }


        public void UpdatePlantList(PlantModel plant)
        {
            plantsListTextBox.Items.Add(plant.Plant);
        }

        private void newGardenButton_Click(object sender, EventArgs e)
        {

        }
    }
}
