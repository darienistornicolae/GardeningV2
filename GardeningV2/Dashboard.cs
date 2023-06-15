using Gardening;
using Newtonsoft.Json;
using System;

namespace GardeningV2
{
    public partial class Dashboard : Form
    {
        private CustomerModel customer;
        private GardenModel garden;
        private GardenModel selectedGarden;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string customerJson = File.ReadAllText("customer.json");
            customer = JsonConvert.DeserializeObject<CustomerModel>(customerJson);

            garden = customer?.Gardens.FirstOrDefault();

            if (garden != null)
            {
                gardenNameLabel.Text = garden.GardenName;

                plantsListTextBox.Items.Clear();

                foreach (PlantModel plant in garden.PlantsInGarden)
                {
                    plantsListTextBox.Items.Add(plant.Plant);
                }

                if (garden.PlantsInGarden.Count > 0)
                {
                    plantsListTextBox.SelectedIndex = 0;

                    PlantModel selectedPlant = garden.PlantsInGarden[plantsListTextBox.SelectedIndex];
                    UpdatePlantDetails(selectedPlant);
                }
                else
                {
                    ClearPlantDetails();
                }
            }
            else
            {
                ClearPlantDetails();
            }

            foreach (GardenModel garden in customer.Gardens)
            {
                existingGardensComboBox.Items.Add(garden.GardenName);
            }

            if (existingGardensComboBox.Items.Count > 0)
            {
                existingGardensComboBox.SelectedIndex = 0;
                selectedGarden = customer.Gardens[existingGardensComboBox.SelectedIndex];
            }

            CalculateBlossomPeak();
            CalculatePrunePeak();
        }

        private void existingGardenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGarden = customer.Gardens[existingGardensComboBox.SelectedIndex];

            gardenNameLabel.Text = selectedGarden.GardenName;

            plantsListTextBox.Items.Clear();

            foreach (PlantModel plant in selectedGarden.PlantsInGarden)
            {
                plantsListTextBox.Items.Add(plant.Plant);
            }

            if (selectedGarden.PlantsInGarden.Count > 0)
            {
                plantsListTextBox.SelectedIndex = 0;

                PlantModel selectedPlant = selectedGarden.PlantsInGarden[plantsListTextBox.SelectedIndex];
                UpdatePlantDetails(selectedPlant);
            }
            else
            {
                ClearPlantDetails();
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
            if (plantsListTextBox.SelectedItem != null)
            {
                PlantModel selectedPlant = garden.PlantsInGarden[plantsListTextBox.SelectedIndex];

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
            AddGarden addGardenForm = new AddGarden(customer);
            addGardenForm.ShowDialog();
            this.Close();
            RefreshDashboard();
        }

        private void RefreshDashboard()
        {
            string customerJson = File.ReadAllText("customer.json");
            customer = JsonConvert.DeserializeObject<CustomerModel>(customerJson);

            garden = customer?.Gardens.FirstOrDefault();

            if (garden != null)
            {
                gardenNameLabel.Text = garden.GardenName;

                plantsListTextBox.Items.Clear();

                foreach (PlantModel plant in garden.PlantsInGarden)
                {
                    plantsListTextBox.Items.Add(plant.Plant);
                }

                if (garden.PlantsInGarden.Count > 0)
                {
                    plantsListTextBox.SelectedIndex = 0;

                    PlantModel selectedPlant = garden.PlantsInGarden[plantsListTextBox.SelectedIndex];
                    UpdatePlantDetails(selectedPlant);
                }
                else
                {
                    ClearPlantDetails();
                }

                CalculateBlossomPeak();
            }
            else
            {
                ClearPlantDetails();
                blossomPeakLabel.Text = "No Garden";
            }
        }


        private void CalculateBlossomPeak()
        {
            if (garden != null && garden.PlantsInGarden.Count > 0)
            {
                DateTime minStart = DateTime.MaxValue;
                DateTime maxEnd = DateTime.MinValue;

                foreach (PlantModel plant in garden.PlantsInGarden)
                {
                    if (plant.StartBlossomPeriod < minStart)
                        minStart = plant.StartBlossomPeriod;

                    if (plant.EndBlosomPeriod > maxEnd)
                        maxEnd = plant.EndBlosomPeriod;
                }

                if (minStart <= maxEnd)
                {
                    string blossomPeak = $"{minStart.ToShortDateString()} - {maxEnd.ToShortDateString()}";
                    blossomPeakLabel.Text = blossomPeak;
                }
                else
                {
                    blossomPeakLabel.Text = "No Blossom Periods";
                }
            }
            else
            {
                blossomPeakLabel.Text = "No Plants";
            }
        }
        private void CalculatePrunePeak()
        {
            if (garden != null && garden.PlantsInGarden.Count > 0)
            {
                DateTime minStart = DateTime.MaxValue;
                DateTime maxEnd = DateTime.MinValue;

                foreach (PlantModel plant in garden.PlantsInGarden)
                {
                    if (plant.StartPrunePeriods < minStart)
                        minStart = plant.StartPrunePeriods;

                    if (plant.EndPrunePeriods > maxEnd)
                        maxEnd = plant.EndPrunePeriods;
                }

                if (minStart <= maxEnd)
                {
                    string blossomPeak = $"{minStart.ToShortDateString()} - {maxEnd.ToShortDateString()}";
                    prunePeakLabel.Text = blossomPeak;
                }
                else
                {
                    prunePeakLabel.Text = "No Prune Periods";
                }
            }
            else
            {
                prunePeakLabel.Text = "No Plants";
            }
        }

        private void removeGardenButton_Click(object sender, EventArgs e)
        {
            if (selectedGarden != null && customer != null)
            {
                customer.Gardens.Remove(selectedGarden);

                selectedGarden = null;
                ClearPlantDetails();
                existingGardensComboBox.Items.Remove(existingGardensComboBox.SelectedItem);
                existingGardensComboBox.SelectedIndex = -1;

                SaveDataToJSON();
            }
        }


    }
}
