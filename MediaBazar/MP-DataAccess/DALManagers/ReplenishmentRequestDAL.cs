using MP_BusinessLogic.Entities;
using MP_BusinessLogic.InterfacesDal;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MP_DataAccess.DALManagers
{
    public class ReplenishmentRequestDAL : Connection, IReplenishmentRequestDAL
    {
        public List<ReplenishmentRequest> GetAllRequests()
        {
            List<ReplenishmentRequest> requests = new List<ReplenishmentRequest>();
            string query = "SELECT * FROM ReplenishmentRequests";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReplenishmentRequest request = new ReplenishmentRequest
                {
                    Id = (int)reader["Id"],
                    ProductId = (int)reader["ProductId"],
                    RequestedQuantity = (int)reader["RequestedQuantity"],
                    Status = reader["Status"].ToString(),
                    RequestDate = (DateTime)reader["RequestDate"],
                    ApprovedDate = reader["ApprovedDate"] as DateTime?,
                    ApprovedBy = reader["ApprovedBy"]?.ToString()
                };
                requests.Add(request);
            }
            connection.Close();
            return requests;
        }

        public List<ReplenishmentRequest> GetRequestsByProductId(int productId)
        {
            List<ReplenishmentRequest> requests = new List<ReplenishmentRequest>();
            string query = "SELECT * FROM ReplenishmentRequests WHERE ProductId = @ProductId AND Status = 'OPEN'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductId", productId);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReplenishmentRequest request = new ReplenishmentRequest
                {
                    Id = (int)reader["Id"],
                    ProductId = (int)reader["ProductId"],
                    RequestedQuantity = (int)reader["RequestedQuantity"],
                    Status = reader["Status"].ToString(),
                    RequestDate = (DateTime)reader["RequestDate"],
                    ApprovedDate = reader["ApprovedDate"] as DateTime?,
                    ApprovedBy = reader["ApprovedBy"]?.ToString()
                };
                requests.Add(request);
            }
            connection.Close();
            return requests;
        }

        public void CreateRequest(ReplenishmentRequest replenishmentRequest)
        {
            string query = "INSERT INTO ReplenishmentRequests (ProductId, RequestedQuantity, Status, RequestDate) VALUES (@ProductId, @RequestedQuantity, @Status, @RequestDate)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductId", replenishmentRequest.ProductId);
            command.Parameters.AddWithValue("@RequestedQuantity", replenishmentRequest.RequestedQuantity);
            command.Parameters.AddWithValue("@Status", replenishmentRequest.Status);
            command.Parameters.AddWithValue("@RequestDate", replenishmentRequest.RequestDate);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateRequest(ReplenishmentRequest replenishmentRequest)
        {
            string query = "UPDATE ReplenishmentRequests SET Status = @Status, ApprovedDate = @ApprovedDate, ApprovedBy = @ApprovedBy WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Status", replenishmentRequest.Status);
            command.Parameters.AddWithValue("@ApprovedDate", (object)replenishmentRequest.ApprovedDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@ApprovedBy", (object)replenishmentRequest.ApprovedBy ?? DBNull.Value);
            command.Parameters.AddWithValue("@Id", replenishmentRequest.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
