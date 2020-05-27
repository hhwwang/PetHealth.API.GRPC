using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PetHealth.API.GRPC
{
    public class ShoppingCartRepository
    {
        private readonly IConfiguration _configuration;

        public ShoppingCartRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public InsuranceTrialLinkGetResponse GetInsuranceTrialLink (InsuranceTrialLinkGetRequest request)
        {
            var response = new InsuranceTrialLinkGetResponse();
            string connectionString = _configuration.GetConnectionString("shoppingCartConnection");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spShoppingCartTrialURLGet", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("state", request.State);
                cmd.Parameters.AddWithValue("server", request.Server);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        response.IsValid = (bool)reader["IsValid"];
                        response.ErrorMessage = reader["Message"].ToString();
                        response.Userid = reader["UserIDStr"].ToString();
                        response.CountryCode = reader["CountryCode"].ToString();
                    }

                    reader.NextResult();
                    while (reader.Read())
                    {
                        response.TrialURL = reader["URL"].ToString();
                    }
                }
            }
            return response;
        }


    }
}
