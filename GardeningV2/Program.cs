using Gardening;
using Newtonsoft.Json;

namespace GardeningV2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            CustomerModel customer = LoadCustomerData();

            if (customer != null && customer.Gardens.Count > 0)
            {
                Application.Run(new Dashboard());
            }
            else
            {
                Application.Run(new Onboarding());
            }
        }

        private static CustomerModel LoadCustomerData()
        {
            try
            {
                string customerJson = File.ReadAllText("customer.json");
                return JsonConvert.DeserializeObject<CustomerModel>(customerJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading customer data: " + ex.Message);
                return null;
            }
        }
    }
}
