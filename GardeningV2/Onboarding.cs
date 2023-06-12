using System;
using System.Collections.Generic;
using System.IO;
using Gardening;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GardeningV2
{
    public partial class Onboarding : Form
    {
        private CustomerModel customer;
        private GardenModel garden;

        public Onboarding()
        {
            InitializeComponent();
            customer = new CustomerModel();
            garden = null;

            // Populate the plantColorComboBox with colors from the Color enum
            plantColorComboBox.DataSource = Enum.GetValues(typeof(Gardening.Color));
        }

        private void createGardenButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerNameTextBox.Text) || string.IsNullOrEmpty(gardenNameTextBox.Text))
            {
                MessageBox.Show("Please enter a valid customer name and garden name.");
                return;
            }

            if (customer == null)
            {
                customer = new CustomerModel(customerNameTextBox.Text);
            }

            if (garden != null)
            {
                MessageBox.Show("A garden has already been created.");
                return;
            }

            garden = new GardenModel(gardenNameTextBox.Text);
            customer.AddGarden(garden);

            // Save customer and garden to a JSON file
            SaveDataToJSON();

            MessageBox.Show("Garden created successfully!");
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
            PlantModel plant = new PlantModel(
                plantNameTextBox.Text.ToString(),
                color,
                plantTypeTextBox.Text,
                pruneStart,
                pruneEnd,
                blossomStart,
                blossomEnd
            );

            garden.AddPlant(plant);
            plantsListBox.Items.Add(plant);

            // Save updated garden to a JSON file
            SaveDataToJSON();

            ClearPlantFields();
        }



        private void getInfoButton_Click(object sender, EventArgs e)
        {
            if (plantsListBox.SelectedItem != null)
            {
                PlantModel selectedPlant = (PlantModel)plantsListBox.SelectedItem;
                MessageBox.Show($"Plant: {selectedPlant.Plant}\nColor: {selectedPlant.Color}\nType: {selectedPlant.Type}\nBlossom Period: {selectedPlant.StartBlossomPeriod.ToShortDateString()} - {selectedPlant.EndBlosomPeriod.ToShortDateString()}\nPrune Period: {selectedPlant.StartPrunePeriods.ToShortDateString()} - {selectedPlant.EndPrunePeriods.ToShortDateString()}");
            }
            else
            {
                MessageBox.Show("Please select a plant from the list.");
            }
        }

        private void removePlantButton_Click(object sender, EventArgs e)
        {
            if (plantsListBox.SelectedItem != null)
            {
                PlantModel selectedPlant = (PlantModel)plantsListBox.SelectedItem;
                garden.DeletePlant(selectedPlant);
                plantsListBox.Items.Remove(selectedPlant);

                SaveDataToJSON();
            }
            else
            {
                MessageBox.Show("Please select a plant from the list.");
            }
        }

        private void SaveDataToJSON()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            // Add StringEnumConverter to serialize the Color enum as strings
            settings.Converters.Add(new StringEnumConverter());

            string customerJson = JsonConvert.SerializeObject(customer, settings);
            File.WriteAllText("customer.json", customerJson);

            if (garden != null)
            {
                string gardenJson = JsonConvert.SerializeObject(garden, settings);
                File.WriteAllText("garden.json", gardenJson);
            }
        }

        private void ClearPlantFields()
        {
            plantNameTextBox.Text = string.Empty;
            plantTypeTextBox.Text = string.Empty;
            plantColorComboBox.SelectedItem = null;
        }


        private void goToDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();

            Dashboard dashboardForm = new Dashboard();

            dashboardForm.Show();
        }

    }
}