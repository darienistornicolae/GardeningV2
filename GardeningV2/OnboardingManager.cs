using System;
using System.Collections.Generic;
using System.IO;
using Gardening;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GardeningV2
{
    public class OnboardingManager
    {
        private CustomerModel customer;
        private GardenModel garden;

        public OnboardingManager()
        {
            customer = new CustomerModel();
            garden = null;
        }
        public List<PlantModel> GetPlants()
        {
            if (garden != null)
            {
                return garden.PlantsInGarden;
            }
            else
            {
                return new List<PlantModel>();
            }
        }

        public void CreateGarden(string customerName, string gardenName)
        {
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(gardenName))
            {
                MessageBox.Show("Please enter a valid customer name and garden name.");
                return;
            }

            if (customer == null)
            {
                customer = new CustomerModel(customerName);
            }
            else
            {
                customer.Name = customerName; 
            }

            if (garden != null)
            {
                MessageBox.Show("A garden has already been created.");
                return;
            }

            garden = new GardenModel(gardenName);
            customer.AddGarden(garden);

            SaveDataToJSON();

            MessageBox.Show("Garden created successfully!");
        }

        public void AddPlant(string plantName, Gardening.Color color, string plantType, DateTime pruneStart, DateTime pruneEnd, DateTime blossomStart, DateTime blossomEnd)
        {
            if (garden == null)
            {
                MessageBox.Show("Please create a garden first.");
                return;
            }

            if (string.IsNullOrEmpty(plantName) || string.IsNullOrEmpty(plantType) || color == null)
            {
                MessageBox.Show("Please enter all the plant details.");
                return;
            }

            if (pruneStart > pruneEnd || blossomStart > blossomEnd)
            {
                MessageBox.Show("Please select valid periods.");
                return;
            }

            PlantModel plant = new PlantModel(
                plantName,
                color,
                plantType,
                pruneStart,
                pruneEnd,
                blossomStart,
                blossomEnd
            );

            garden.AddPlant(plant);

            SaveDataToJSON();

        }

        public void GetPlantInfo(PlantModel selectedPlant)
        {
            if (selectedPlant != null)
            {
                MessageBox.Show($"Plant: {selectedPlant.Plant}\nColor: {selectedPlant.Color}\nType: {selectedPlant.Type}\nBlossom Period: {selectedPlant.StartBlossomPeriod.ToShortDateString()} - {selectedPlant.EndBlosomPeriod.ToShortDateString()}\nPrune Period: {selectedPlant.StartPrunePeriods.ToShortDateString()} - {selectedPlant.EndPrunePeriods.ToShortDateString()}");
            }
            else
            {
                MessageBox.Show("Please select a plant from the list.");
            }
        }

        public void RemovePlant(PlantModel selectedPlant)
        {
            if (selectedPlant != null)
            {
                garden.DeletePlant(selectedPlant);

                SaveDataToJSON();
            }
            else
            {
                MessageBox.Show("Please select a plant from the list.");
            }
        }

        public bool HasGarden()
        {
            return garden != null;
        }


        private void SaveDataToJSON()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            settings.Converters.Add(new StringEnumConverter());

            string customerJson = JsonConvert.SerializeObject(customer, settings);
            File.WriteAllText("customer.json", customerJson);

            if (garden != null)
            {
                string gardenJson = JsonConvert.SerializeObject(garden, settings);
                File.WriteAllText("garden.json", gardenJson);
            }
        }

    }
}
