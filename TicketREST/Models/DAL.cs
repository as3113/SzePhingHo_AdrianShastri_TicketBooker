using System.Data;
using System.Data.SqlClient;

namespace TicketREST.Models
{
    public class DAL
    {
        public Response GetAllTickets(SqlConnection connection)
        {
            Response response = new Response();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tickets", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<Ticket> listTicket = new List<Ticket>();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++) 
                { 
                    Ticket ticket = new Ticket();
                    ticket.ticketId = Convert.ToInt32(dt.Rows[i]["id"]);
                    ticket.train = Convert.ToString(dt.Rows[i]["train"]);
                    ticket.departure = Convert.ToString(dt.Rows[i]["departure"]);
                    ticket.destination = Convert.ToString(dt.Rows[i]["destination"]);
                    ticket.departureTime = Convert.ToDateTime(dt.Rows[i]["departureTime"]);
                    ticket.arrivalTime = Convert.ToDateTime(dt.Rows[i]["arrivalTime"]);
                    ticket.category = Convert.ToString(dt.Rows[i]["category"]);
                    ticket.seat = Convert.ToString(dt.Rows[i]["seat"]);
                    ticket.price = Convert.ToDecimal(dt.Rows[i]["price"]);

                    listTicket.Add(ticket);
                }
            }
            if(listTicket.Count > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Data found";
                response.TicketList = listTicket;
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No data found";
                response.TicketList = null;
            }

            return response;
        }

        public Response GetTicketById(SqlConnection connection, int id)
        {
            Response response = new Response();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tickets WHERE id = '" + id + "'", connection);
            DataTable dt = new DataTable();
            Ticket tickets = new Ticket();
            da.Fill(dt);

            List<Ticket> listTicket = new List<Ticket>(); // keep this for date search

            if (dt.Rows.Count > 0)
            {
                Ticket ticket = new Ticket();
                ticket.ticketId = Convert.ToInt32(dt.Rows[0]["id"]);
                ticket.train = Convert.ToString(dt.Rows[0]["train"]);
                ticket.departure = Convert.ToString(dt.Rows[0]["departure"]);
                ticket.destination = Convert.ToString(dt.Rows[0]["destination"]);
                ticket.departureTime = Convert.ToDateTime(dt.Rows[0]["departureTime"]);
                ticket.arrivalTime = Convert.ToDateTime(dt.Rows[0]["arrivalTime"]);
                ticket.category = Convert.ToString(dt.Rows[0]["category"]);
                ticket.seat = Convert.ToString(dt.Rows[0]["seat"]);
                ticket.price = Convert.ToDecimal(dt.Rows[0]["price"]);

                response.StatusCode = 200;
                response.StatusMessage = "Data found";
                response.Ticket = ticket;
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No data found";
                response.TicketList = null;
            }

            return response;
        }

        public Response AddTicket(SqlConnection connection, Ticket ticket)
        {
            Response response = new Response();

            string query = "INSERT INTO tickets " +
                   "(id, train, departure, destination, departureTime, arrivalTime, category, seat, price) " +
                   "VALUES (@Id, @Train, @Departure, @Destination, @DepartureTime, @ArrivalTime, @Category, @Seat, @Price)";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Id", ticket.ticketId);
                cmd.Parameters.AddWithValue("@Train", ticket.train);
                cmd.Parameters.AddWithValue("@Departure", ticket.departure);
                cmd.Parameters.AddWithValue("@Destination", ticket.destination);
                cmd.Parameters.AddWithValue("@DepartureTime", ticket.departureTime);
                cmd.Parameters.AddWithValue("@ArrivalTime", ticket.arrivalTime);
                cmd.Parameters.AddWithValue("@Category", ticket.category);
                cmd.Parameters.AddWithValue("@Seat", ticket.seat);
                cmd.Parameters.AddWithValue("@Price", ticket.price);

                connection.Open();
                int i = cmd.ExecuteNonQuery();
                connection.Close();

                List<Ticket> listTicket = new List<Ticket>(); // keep this for date search

                if (i > 0)
                {
                    response.StatusCode = 200;
                    response.StatusMessage = "Ticket added";
                    response.Ticket = ticket;
                }
                else
                {
                    response.StatusCode = 100;
                    response.StatusMessage = "No ticket added";
                    response.TicketList = null;
                }

                return response;
            }
        }

        public Response UpdateTicket(SqlConnection connection, Ticket ticket)
        {
            Response response = new Response();
            SqlCommand cmd = new SqlCommand("UPDATE tickets SET departure = '" + ticket.departure + "' WHERE id = '" + ticket.ticketId + "'", connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();

            List<Ticket> listTicket = new List<Ticket>(); // keep this for date search

            if (i > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Ticket updated";
                response.Ticket = ticket;
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No ticket updated";
                response.TicketList = null;
            }

            return response;
        }

        public Response DeleteTicket(SqlConnection connection, int id)
        {
            Response response = new Response();
            SqlCommand cmd = new SqlCommand("DELETE FROM tickets WHERE id = '" + id + "'", connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();

            List<Ticket> listTicket = new List<Ticket>(); // keep this for date search

            if (i > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Ticket deleted";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No ticket deleted";
            }

            return response;
        }

        public Response SearchTicketsByDate(SqlConnection connection, DateSearchCriteria searchCriteria)
        {
            Response response = new Response();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tickets WHERE CONVERT(DATE, departureTime) = @Date", connection);
            da.SelectCommand.Parameters.AddWithValue("@Date", searchCriteria.Date);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<Ticket> listTicket = new List<Ticket>();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ticket ticket = new Ticket();
                    ticket.ticketId = Convert.ToInt32(dt.Rows[i]["id"]);
                    ticket.train = Convert.ToString(dt.Rows[i]["train"]);
                    ticket.departure = Convert.ToString(dt.Rows[i]["departure"]);
                    ticket.destination = Convert.ToString(dt.Rows[i]["destination"]);
                    ticket.departureTime = Convert.ToDateTime(dt.Rows[i]["departureTime"]);
                    ticket.arrivalTime = Convert.ToDateTime(dt.Rows[i]["arrivalTime"]);
                    ticket.category = Convert.ToString(dt.Rows[i]["category"]);
                    ticket.seat = Convert.ToString(dt.Rows[i]["seat"]);
                    ticket.price = Convert.ToDecimal(dt.Rows[i]["price"]);

                    listTicket.Add(ticket);
                }
            }

            if (listTicket.Count > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Data found";
                response.TicketList = listTicket;
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No data found";
                response.TicketList = null;
            }

            return response;
        }

    }
}
