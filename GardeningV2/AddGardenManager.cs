using Gardening;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;

namespace GardeningV2
{

    namespace GardeningV2
    {
        public class AddGardenManager
        {
            public void SaveDataToJSON(CustomerModel customer)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented
                };
                settings.Converters.Add(new StringEnumConverter());
                string updatedCustomerJson = JsonConvert.SerializeObject(customer, settings);
                File.WriteAllText("customer.json", updatedCustomerJson);
            }
        }
    }

}
