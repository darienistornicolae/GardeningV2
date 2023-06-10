using System;
using System.Collections.Generic;
using System.Linq;

namespace Gardening
{
    public class CustomerModel
    {
        private string name;
        private List<GardenModel> gardens;

        public CustomerModel(string name)
        {
            this.name = name;
            gardens = new List<GardenModel>();
        }

        public CustomerModel() { }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public List<GardenModel> Gardens
        {
            get { return gardens; }
        }

        public void AddGarden(string gardenName)
        {
            GardenModel garden = new GardenModel(gardenName);
            gardens.Add(garden);
        }

        public void DeleteGarden(GardenModel garden)
        {
            gardens.Remove(garden);
        }
    }
}
