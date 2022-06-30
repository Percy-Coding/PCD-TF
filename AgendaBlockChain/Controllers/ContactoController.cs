using AgendaBlockChain.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE Contact WHERE ID=@ID", connection);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Read()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Contact", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Console.WriteLine("Nombre: {0}, Numero: {1}", dr["Name"].ToString(), dr["Number"].ToString());
            }
        }

        public void Update(int id, Contacto model)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Contact SET Name = @Name, Number = @Number WHERE ID = @ID)", connection);
            cmd.Parameters.AddWithValue("@Name", model.Name);
            cmd.Parameters.AddWithValue("@Number", model.Number);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
