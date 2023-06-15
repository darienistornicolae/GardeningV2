using System;
using System.Collections.Generic;
using System.IO;
using Gardening;
using GardeningV2;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GardeningV2
{
    public partial class Onboarding : Form
    {
        private OnboardingManager onboardingManager;

        public Onboarding()
        {
            InitializeComponent();
            onboardingManager = new OnboardingManager();

            plantColorComboBox.DataSource = Enum.GetValues(typeof(Gardening.Color));
        }

        private void createGardenButton_Click(object sender, EventArgs e)
        {
            string customerName = customerNameTextBox.Text;
            string gardenName = gardenNameTextBox.Text;

            onboardingManager.CreateGarden(customerName, gardenName);
        }

        private void addPlantButton_Click(object sender, EventArgs e)
        {
            string plantName = plantNameTextBox.Text;
            Gardening.Color color = (Gardening.Color)plantColorComboBox.SelectedItem;
            string plantType = plantTypeTextBox.Text;
            DateTime pruneStart = pruneStartPeriodTimePicker.Value;
            DateTime pruneEnd = pruneEndTimePicker.Value;
            DateTime blossomStart = blossomStartTimePicker.Value;
            DateTime blossomEnd = blossomEndTimerPeriod.Value;

            onboardingManager.AddPlant(plantName, color, plantType, pruneStart, pruneEnd, blossomStart, blossomEnd);
            UpdatePlantsListBox();
        }
        private void UpdatePlantsListBox()
        {
            plantsListBox.Items.Clear();
            List<PlantModel> plants = onboardingManager.GetPlants();

            foreach (PlantModel plant in plants)
            {
                plantsListBox.Items.Add(plant);
            }
        }

        private void getInfoButton_Click(object sender, EventArgs e)
        {
            if (plantsListBox.SelectedItem != null)
            {
                PlantModel selectedPlant = (PlantModel)plantsListBox.SelectedItem;
                onboardingManager.GetPlantInfo(selectedPlant);
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
                onboardingManager.RemovePlant(selectedPlant);
            }
            else
            {
                MessageBox.Show("Please select a plant from the list.");
            }
        }

        private void goToDashboard_Click(object sender, EventArgs e)
        {
            if (onboardingManager.HasGarden())
            {
                this.Hide();

                Dashboard dashboardForm = new Dashboard();

                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Please create a garden and add some plants first.");
            }
        }

    }

}



