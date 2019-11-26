using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SampleASPCore.Models;

namespace SampleASPCore.Services
{
    public class RestaurantService : IRestaurantData
    {
        private readonly IConfiguration _config;

        public RestaurantService(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnectionString()
        {
            return _config.GetConnectionString("DefaultConnection");
        }
        public IEnumerable<Restaurant> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                List<Restaurant> listRestaurant = new List<Restaurant>();
                string strSql = @"select * from Restaurants order by Id";
                SqlCommand cmd = new SqlCommand(strSql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        listRestaurant.Add
                        (
                            new Restaurant {
                                Id = Convert.ToInt32(dr["Id"]),
                                Name = dr["Name"].ToString(),
                                Description = dr["Description"].ToString()
                            }
                        );
                    };
                }
                dr.Close();
                cmd.Dispose();
                conn.Close();

                return listRestaurant;
            }
        }

        public Restaurant GetByID(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}