using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System.Data.SqlClient;
using TicketREST.Controllers;
using TicketREST.Models;

namespace TicketRESTNUnit
{
    public class Tests
    {
        private IConfiguration _configuration;
        private TicketController _ticketController;

        [SetUp]
        public void Setup()
        {
            // Testing the connection string in appsettings
            // Set up the configuration 
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings-test.json") // Create a separate appsettings-test.json for testing
                .Build();
        }

        // Test GetAllTickets method
        [Test]
        public void TestGetAllTickets()
        {
            // Arrange - No specific arrangement needed in this case as it's a read-only operation
            _ticketController = new TicketController(_configuration);

            // Act
            Response response = _ticketController.GetAllTickets();

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(200, response.StatusCode); // Assuming the API returns 200 status code on success
            Assert.IsNotNull(response.TicketList); // Ensure that the TicketList is not null
            // You can add more specific assertions to verify the correctness of the data returned by the API
        }

        // Test SearchTicketsByDate method
        [Test]
        public void TestSearchTicketsByDate()
        {
            // Arrange - No specific arrangement needed in this case as it's a read-only operation
            _ticketController = new TicketController(_configuration);

            // Create a DateSearchCriteria object with a specific date for testing
            DateSearchCriteria searchCriteria = new DateSearchCriteria
            {
                Date = new DateTime(2023, 08, 15) // Replace this with the desired date for testing
            };

            // Act
            Response response = _ticketController.SearchTicketsByDate(searchCriteria);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(200, response.StatusCode); // Assuming the API returns 200 status code on success
            Assert.IsNotNull(response.TicketList); // Ensure that the TicketList is not null
            // You can add more specific assertions to verify the correctness of the data returned by the API
        }
    }
}