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
            throw new NotImplementedException();
        }

        public ClientPOCO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientPOCO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ClientPOCO obj)
        {
            throw new NotImplementedException();
        }
    }
}
