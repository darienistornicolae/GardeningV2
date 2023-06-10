namespace Gardening
{
    public class GardenModel
    {
        private string gardenName;
        private List<PlantModel> plantsInGarden;

        public GardenModel(string gardenName)
        {
            this.gardenName = gardenName;
            plantsInGarden = new List<PlantModel>();
        }

        public string GardenName
        {
            get { return gardenName; }
            set { gardenName = value; }
        }

        public List<PlantModel> PlantsInGarden
        {
            get { return plantsInGarden; }
        }

        public void AddPlant(PlantModel plant)
        {
            plantsInGarden.Add(plant);
        }

        public void DeletePlant(PlantModel plant)
        {
            plantsInGarden.Remove(plant);
        }
    }
}
