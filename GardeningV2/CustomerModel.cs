using System;
using System.Collections.Generic;
using System.Linq;

namespace Gardening
{
    public class CustomerModel
    {
        public string Name { get; set; }

        private List<GardenModel> gardens;

        public CustomerModel(string name)
        {
            Name = name;
            gardens = new List<GardenModel>();
        }

        public CustomerModel()
        {
            gardens = new List<GardenModel>();
        }

        public List<GardenModel> Gardens
        {
            get { return gardens; }
        }

        public void AddGarden(GardenModel garden)
        {
            gardens.Add(garden);
        }

        public void DeleteGarden(GardenModel garden)
        {
            gardens.Remove(garden);
        }
    }


}
