using Gardening;
using Newtonsoft.Json;
using System.IO;

namespace GardeningV2
{
    public class PlantManager
    {
        private CustomerModel customer;
        private GardenModel garden;
        private PlantModel plant;
        public PlantManager(CustomerModel customer, GardenModel garden)
        {
            this.customer = customer;
            this.garden = garden;
        }

        public void AddPlant(string name, Gardening.Color color, string type, DateTime pruneStart, DateTime pruneEnd, DateTime blossomStart, DateTime blossomEnd)
        {
            if (garden == null)
            {
                return; // Or throw an exception, show an error message, etc.
            }

            PlantModel plant = new PlantModel(name, color, type, pruneStart, pruneEnd, blossomStart, blossomEnd);
            garden.AddPlant(plant);

            SaveDataToJSON();
        }


        private void SaveDataToJSON()
        {
            string customerJson = File.ReadAllText("customer.json");
            customer = JsonConvert.DeserializeObject<CustomerModel>(customerJson);

            garden = customer?.Gardens.Find(g => g.GardenName == garden.GardenName);

            if (garden != null)
            {
                garden.PlantsInGarden.Add(plant);
            }
            else
            {
                garden = new GardenModel("Your Garden Name");
                garden.PlantsInGarden.Add(plant);
                customer?.Gardens.Add(garden);
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
