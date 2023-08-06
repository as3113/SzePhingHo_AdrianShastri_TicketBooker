using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TicketTest.Models;
using Newtonsoft.Json;
/*using System.Text.Json.Serialization;*/

namespace TicketTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Search : Window
    {
        public Search()
        {
            InitializeComponent();
        }

        private void tbFrom_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
        }

        private void tbTo_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private async void btnContinue_Click(object sender, RoutedEventArgs e)
        {

            // API endpoint for searching tickets based on date
            string apiUrl = "http://local:7203/api/Ticket/";


            using (HttpClient client = new HttpClient())
            {
                // Set the request headers (if required)
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Capture the input values
                string from = tbFrom.Text;
                string to = tbTo.Text;
                string category = ((ComboBoxItem)cbCategory.SelectedItem).Content.ToString();
                DateTime date = dpDate.SelectedDate ?? DateTime.Now;

                DateSearchCriteria searchCriteria = new DateSearchCriteria
                {
                    Date = date
                };

                string jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(searchCriteria);
                var httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("SearchTicketsByDate", httpContent);

                string responseContent = await response.Content.ReadAsStringAsync();

                Response res = JsonConvert.DeserializeObject<Response>(responseContent);
                Result.ItemsSource = res.TicketList;
                // Display the results in the Testing window


                // Close the current Search window
                this.Close();
            }

        }

        /*private async Task<Response> SearchForTickets(DateSearchCriteria searchCriteria)
        {
            try
            {
                // API endpoint for searching tickets based on date
                string apiUrl = "http://local:7203/api/Ticket/SearchTicketsByDate";

                using (HttpClient client = new HttpClient())
                {
                    // Set the request headers (if required)
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Convert the search criteria object to JSON
                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(searchCriteria);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // Send the POST request to the API
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    response.EnsureSuccessStatusCode();

                    // Read the response content as JSON and deserialize to Response object
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Response result = Newtonsoft.Json.JsonConvert.DeserializeObject<Response>(responseContent);

                    return result;
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }*/


    }

}
