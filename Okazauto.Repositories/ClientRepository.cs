using Microsoft.Data.SqlClient;
using Okazauto.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okazauto.Repositories
{
    public class ClientRepository : IRepository<ClientPOCO, int>
    {
        private string _connection;
        public ClientRepository(string connection)
        {
            _connection = connection;
        }

  

        public int Add(ClientPOCO clientPOCO)
        {
            int id;
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.InsertClient",connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nom", clientPOCO.Nom);
                    command.Parameters.AddWithValue("@Prenom", clientPOCO.Prenom);
                    command.Parameters.AddWithValue("@Telephone", clientPOCO.Telephone);
                    command.Parameters.AddWithValue("@Email", clientPOCO.Email);
                    command.Parameters.AddWithValue("@Adresse", clientPOCO.Adresse);

                    id = (int)command.ExecuteScalar();
                }
                connection.Close();
            }
            
            return id;
        }

        public void Delete(int id)
        {
            
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                
               
                using (SqlCommand command = new SqlCommand("dbo.DeleteClient",connection)) 
                {
                    command.CommandType=CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
             
            }
            
        }
        public ClientPOCO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientPOCO> GetAll()
        {
            List<ClientPOCO> clients = new List<ClientPOCO>();
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                using (SqlCommand command = new SqlCommand("dbo.GetClient", connection)) 
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            ClientPOCO client = new ClientPOCO
                            {
                                Id = (int)reader["Id"],
                                Nom = reader["Nom"].ToString(),
                                Prenom = reader["Prenom"].ToString(),
                                Telephone = reader["Telephone"].ToString(),
                                Email = reader["Email"].ToString(),
                                Adresse = reader["Adresse"].ToString()
                            };
                            clients.Add(client);
                           
                        }
                }
             return clients;
                connection.Close();


            }
        }

        public void Update(ClientPOCO obj)
        {
            throw new NotImplementedException();
        }
    }
}


