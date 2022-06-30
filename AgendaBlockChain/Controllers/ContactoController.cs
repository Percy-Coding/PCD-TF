using AgendaBlockChain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AgendaBlockChain.Controllers
{
    public class ContactoController : CRUDController<Contacto>
    {
        string connectionString = "server=(localdb)\\MSSQLLocalDB;database=AgendaBlockChain;Trusted_Connection=true";
        public void Create(Contacto model)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Contact VALUES (@Name,@Number)",connection);
            cmd.Parameters.AddWithValue("@Name", model.Name);
            cmd.Parameters.AddWithValue("@Number", model.Number);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Contacto model)
        {
            throw new NotImplementedException();
        }
    }
}
