using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using TicketREST.Models;
using System.Data.SqlClient;

namespace TicketREST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TicketController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetAllTickets")]
        public Response GetAllTickets()
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
            Response response = new Response();
            DAL dal = new DAL();
            response = dal.GetAllTickets(connection);

            return response;
        }

        [HttpGet]
        [Route("GetTicketById/{id}")]
        public Response GetTicketById(int id) 
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
            Response response = new Response();
            DAL dal = new DAL();
            response = dal.GetTicketById(connection, id);

            return response;
        }

        [HttpPost]
        [Route("AddTicket")]
        public Response AddTicket(Ticket ticket)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
            Response response = new Response();
            DAL dal = new DAL();
            response = dal.AddTicket(connection, ticket);
            return response;
        }

        [HttpPut]
        [Route("UpdateTicket")]
        public Response UpdateTicket(Ticket ticket)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
            Response response = new Response();
            DAL dal = new DAL();
            response = dal.UpdateTicket(connection, ticket);
            return response;
        }

        [HttpDelete]
        [Route("DeleteTicket/{id}")]
        public Response DeleteTicket(int id)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
            Response response = new Response();
            DAL dal = new DAL();
            response = dal.DeleteTicket(connection, id);
            return response;
        }

        [HttpPost]
        [Route("SearchTicketsByDate")]
        public Response SearchTicketsByDate(DateSearchCriteria searchCriteria)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
            Response response = new Response();
            DAL dal = new DAL();
            response = dal.SearchTicketsByDate(connection, searchCriteria);
            return response;
        }
    }
}
