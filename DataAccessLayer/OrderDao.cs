using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WCF.Models;

namespace DataAccessLayer
{
    public class OrderDao : IOrderDao
    {
        private readonly string connectionString;

        public OrderDao()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["Order"].ConnectionString;
        }
        public Order AddOrder(Order order)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandText = "AddOrder";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddRange(new[]
                {
                    new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = order.Name,
                        SqlDbType = SqlDbType.NVarChar,
                        Direction = ParameterDirection.Input
                    }
                });

                var id = new SqlParameter
                {
                    ParameterName = "@Id_output",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output,
                };

                command.Parameters.Add(id);

                connection.Open();

                command.ExecuteNonQuery();

                return GetOrderById((int)id.Value);
            }
        }

        public void DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();

                //название
                command.CommandText = "GetOrdeById";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddRange(new[]
                {
                    new SqlParameter
                    {
                        ParameterName = "@Id",
                        Value = id,
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input
                    }
                });

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new Order
                        {
                            OrderID = (int)reader["id"],
                            Name = (string)reader["Name"]
                        };
                    }
                }
            }
            return null;
        }

        public IEnumerable<Order> GetOrders()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();

                //название
                command.CommandText = "GetOrders";
                command.CommandType = CommandType.StoredProcedure;


                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return new Order
                        {
                            OrderID = (int)reader["id"],
                            Name = (string)reader["Name"]
                        };
                    }
                }
            }
        }

        public IEnumerable<Order> GetOrdersByCustomer(Order customer)
        {
            throw new NotImplementedException();
        }

        public Order UpdateOrder(Order Order)
        {
            throw new NotImplementedException();
        }
    }
}
