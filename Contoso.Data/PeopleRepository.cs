using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
using System.Data.SqlClient;
using System.Data;

namespace Contoso.Data
{
    public class PeopleRepository : IRepository<People>
    {
        public void Create(People obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnection());
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "SP_Create_People";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@PLastName", obj.LastName);
            cmd.Parameters.AddWithValue("@PFirstName", obj.FirstName);
            cmd.Parameters.AddWithValue("@MiddleName", obj.MiddleName);
            cmd.Parameters.AddWithValue("@PAge", obj.Age);
            cmd.Parameters.AddWithValue("@PEmail", obj.Email);
            cmd.Parameters.AddWithValue("@PPhone", obj.Phone);
            cmd.Parameters.AddWithValue("@AddressLine1", obj.AddressLine1);
            cmd.Parameters.AddWithValue("@AddressLine2", obj.AddressLine2);
            cmd.Parameters.AddWithValue("@PUnitOrApartmentNumber", obj.UnitOrApartmentNumber);
            cmd.Parameters.AddWithValue("@PCity", obj.City);
            cmd.Parameters.AddWithValue("@PState", obj.State);
            cmd.Parameters.AddWithValue("@PZipCode", obj.ZipCode);
            cmd.Parameters.AddWithValue("@PCreatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@PCreatedBy", obj.CreatedBy);
            cmd.Parameters.AddWithValue("@PUpdatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@PUpdatedBy", obj.UpdatedBy);
            cmd.Parameters.AddWithValue("@PSalt", obj.Salt);
            cmd.Parameters.AddWithValue("@PIsLocked", obj.IsLocked);
            cmd.Parameters.AddWithValue("@PLastLockedDateTime", DateTime.Now);
            cmd.Parameters.AddWithValue("@PFailedAttempts", obj.FailedAttempts);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
            con.Dispose();

        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<People> GetAll()
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnection());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_GetAll_People";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataReader reader = cmd.ExecuteReader();
            List<People> PersonList = new List<People>();
            while (reader.Read())
            {
                People person = new People();
                person.Id = Convert.ToInt32(reader["Id"]);
                person.LastName = reader["LastName"].ToString();
                person.FirstName = reader["FirstName"].ToString();
                person.MiddleName = reader["MiddleName"].ToString();
                person.Age = Convert.ToInt32(reader["Age"]);
                person.Email = reader["Email"].ToString();
                person.Phone = Convert.ToInt32(reader["Phone"]);
                person.AddressLine1 = reader["AddressLine1"].ToString();
                person.AddressLine2 = reader["AddressLine2"].ToString();
                person.UnitOrApartmentNumber = Convert.ToInt32(reader["UnitOrApartmentNumber"]);
                person.City = reader["City"].ToString();
                person.State = reader["State"].ToString();
                person.ZipCode = Convert.ToInt32(reader["ZipCode"]);
                PersonList.Add(person);

            }
            con.Close();

            cmd.Dispose();
            con.Dispose();
            return PersonList;
        }

        public People GetById(int id)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnection());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_GetByID_People";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Pid", id);
            SqlDataReader reader = cmd.ExecuteReader();
            People person = new People();
            while (reader.Read())
            {
                person.Id = Convert.ToInt32(reader["Id"]);
                person.LastName = reader["LastName"].ToString();
                person.FirstName = reader["FirstName"].ToString();
                person.MiddleName = reader["MiddleName"].ToString();
                person.Age = Convert.ToInt32(reader["Age"]);
                person.Email = reader["Email"].ToString();
                person.Phone = Convert.ToInt32(reader["Phone"]);
                person.AddressLine1 = reader["AddressLine1"].ToString();
                person.AddressLine2 = reader["AddressLine2"].ToString();
                person.UnitOrApartmentNumber = Convert.ToInt32(reader["UnitOrApartmentNumber"]);
                person.City = reader["City"].ToString();
                person.State = reader["State"].ToString();
                person.ZipCode = Convert.ToInt32(reader["ZipCode"]);
            }
            con.Close();

            cmd.Dispose();
            con.Dispose();
            return person;
        }

        public void Update(People obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnection());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_Update_People";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@Pid", obj.Id);
            cmd.Parameters.AddWithValue("@PLastName", obj.LastName);
            cmd.Parameters.AddWithValue("@PFirstName", obj.FirstName);
            cmd.Parameters.AddWithValue("@MiddleName", obj.MiddleName);
            cmd.Parameters.AddWithValue("@PAge", obj.Age);
            cmd.Parameters.AddWithValue("@PEmail", obj.Email);
            cmd.Parameters.AddWithValue("@PPhone", obj.Phone);
            cmd.Parameters.AddWithValue("@AddressLine1", obj.AddressLine1);
            cmd.Parameters.AddWithValue("@AddressLine2", obj.AddressLine2);
            cmd.Parameters.AddWithValue("@PUnitOrApartmentNumber", obj.UnitOrApartmentNumber);
            cmd.Parameters.AddWithValue("@PCity", obj.City);
            cmd.Parameters.AddWithValue("@PState", obj.State);
            cmd.Parameters.AddWithValue("@PZipCode", obj.ZipCode);
            cmd.Parameters.AddWithValue("@PCreatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@PCreatedBy", obj.CreatedBy);
            cmd.Parameters.AddWithValue("@PUpdatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@PUpdatedBy", obj.UpdatedBy);
            cmd.Parameters.AddWithValue("@PSalt", obj.Salt);
            cmd.Parameters.AddWithValue("@PIsLocked", obj.IsLocked);
            cmd.Parameters.AddWithValue("@PLastLockedDateTime", DateTime.Now);
            cmd.Parameters.AddWithValue("@PFailedAttempts", obj.FailedAttempts);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
            con.Dispose();
        }
    }
}
