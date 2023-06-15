using Gardening;
using GardeningV2.GardeningV2;
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

            newGarden = new GardenModel(addNewGardenTextBox.Text);
            customer.AddGarden(newGarden);

            AddGardenManager gardenManager = new AddGardenManager();

            gardenManager.SaveDataToJSON(customer);

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


            AddGardenManager gardenManager = new AddGardenManager();

            gardenManager.SaveDataToJSON(customer);
            ClearPlantFields();
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
            this.Close();

            Dashboard dashboardForm = new Dashboard();

            dashboardForm.Show();
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
                newGarden.DeletePlant(selectedPlant);
                plantsListBox.Items.Remove(selectedPlant);


                AddGardenManager gardenManager = new AddGardenManager();
                gardenManager.SaveDataToJSON(customer);
            }
            else
            {
                MessageBox.Show("Please select a plant from the list.");
            }
        }

    }
}
