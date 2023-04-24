using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;


namespace Supermarket_mvp._Repositories
{
    internal class ProductRepository
    {
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(PayModeModel payModeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Product VALUES (@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = payModeModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = payModeModel.Observation;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Product WHERE ProductId=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }


        }

        public void Edit(PayModeModel payModeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE  Product
                                        SET ProductName =@name,
                                        ProductObservation=@observation
                                        WHERE ProductId=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = productModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.Id;
                command.ExecuteNonQuery();
            }

        }

        public IEnumerable<ProductModel> GetAll()
        {
            var payModeList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Product ORDER BY ProductId DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.Id = (int)reader["ProductId"];
                        payModeModel.Name = reader["ProductName"].ToString();
                        payModeModel.Observation = reader["ProductObservation"].ToString();
                        payModeList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<PayModeModel> GetByValue(string value)
        {
            var productList = new List<PayModeModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM product
                                    WHERE Productid=@id or ProductName LIKE @name+ '%'
                                    ORDER By ProductId DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.Id = (int)reader["Pay_Mode_Id"];
                        payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        payModeModel.Observation = reader["Pay_Mode_Observation"].ToString();
                        productList.Add(payModeModel);
                    }
                }
            }
            return productList;
        }
    }
}
