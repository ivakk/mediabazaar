using MP_BusinessLogic.Entities;
using MP_DataAccess.DALManagers;
using System.Data.SqlClient;
using MP_BusinessLogic.InterfacesDal;

public class ReplenishmentRequestDAL : Connection, IReplenishmentRequestDAL
{
    private readonly string tableName = "ReplenishmentRequests";

    public void CreateRequest(ReplenishmentRequest replenishmentRequest)
    {
        string query = $"INSERT INTO {tableName} (ProductId, RequestedQuantity, Status, RequestDate) " +
                       $"VALUES (@ProductId, @RequestedQuantity, @Status, @RequestDate)";

        connection.Open();
        SqlCommand command = new SqlCommand(query, base.connection);
        command.Parameters.AddWithValue("@ProductId", replenishmentRequest.ProductId);
        command.Parameters.AddWithValue("@RequestedQuantity", replenishmentRequest.RequestedQuantity);
        command.Parameters.AddWithValue("@Status", replenishmentRequest.Status);
        command.Parameters.AddWithValue("@RequestDate", replenishmentRequest.RequestDate);

        try
        {
            command.ExecuteNonQuery();
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    public List<ReplenishmentRequest> GetAllRequests()
    {
        string query = $"SELECT * FROM {tableName}";
        List<ReplenishmentRequest> requests = new List<ReplenishmentRequest>();

        connection.Open();
        SqlCommand command = new SqlCommand(query, base.connection);

        try
        {
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                requests.Add(new ReplenishmentRequest
                {
                    Id = (int)reader["Id"],
                    ProductId = (int)reader["ProductId"],
                    RequestedQuantity = (int)reader["RequestedQuantity"],
                    Status = (string)reader["Status"],
                    RequestDate = (DateTime)reader["RequestDate"],
                    ApprovedDate = reader["ApprovedDate"] as DateTime?,
                    ApprovedBy = reader["ApprovedBy"] as string
                });
            }
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }

        return requests;
    }
}
