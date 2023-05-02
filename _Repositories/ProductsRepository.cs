using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarker_mvp.Models;
using System.Data;

namespace Supermarker_mvp._Repositories
{
    internal class ProductsRepository : BaseRepository, IProductsRepository
    {
        public ProductsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ProductsModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Products VALUES(@name , @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = productsModel.Observation;
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
                command.CommandText = "DELETE FROM Products WHERE Products_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            }
        }

        public void Edit(ProductsModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE PayMode
                                        SET Pay_Mode_Name = @name,
                                        Pay_Mode_Observation = @observation
                                        WHERE Pay_Mode_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = productsModel.Observation;
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = productsModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductsModel> GetAll()
        {
            var productsList = new List<ProductsModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products ORDER BY Products_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Products_Id"];
                        productsModel.Name = reader["Products_Name"].ToString();
                        productsModel.Observation = reader["Products_Observation"].ToString();
                        productsList.Add(productsModel);
                    }
                }
            }
            return productsList;
        }

        public IEnumerable<ProductsModel> GetByValue(string value)
        {
            var productsList = new List<ProductsModel>();
            int productsId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productsName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Products
                                        WHERE Products_Id = @id or Products_Name LIKE @name+ ´%´
                                        ORDER BY Products_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productsId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Products_Id"];
                        productsModel.Name = reader["Products_Id"].ToString();
                        productsModel.Observation = reader["Products_Id"].ToString();
                        productsList.Add(productsModel);
                    }
                }
            }
            return productsList;
        }
    }
}
