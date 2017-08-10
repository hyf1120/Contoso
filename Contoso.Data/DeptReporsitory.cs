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
    public class DeptReporsitory : IRepository<Departments>
    {
        // 
        public void Create(Departments obj)
        {
            // using try catch block;
            SqlConnection con = new SqlConnection(DBHelper.GetConnection());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_Create_Dep";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@DName", obj.Name);
            cmd.Parameters.AddWithValue("@Dbudget", obj.Budget);
            cmd.Parameters.AddWithValue("@DStartDate", obj.StartDate);
            cmd.Parameters.AddWithValue("@DInstructorId", obj.InstructorId);
            cmd.Parameters.AddWithValue("@DRowVersion", obj.RowVersion);
            cmd.Parameters.AddWithValue("@DCreatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@DCreatedBy", obj.CreatedBy);
            cmd.Parameters.AddWithValue("@DUpdatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@DUpdatedBy", obj.UpdatedBy);

            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();

        }

        public void DeleteById(int id)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnection());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_Delete_Dep";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }

        public List<Departments> GetAll()
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnection());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_GetAll_Dep";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataReader reader = cmd.ExecuteReader();
            List<Departments> DepartmentList = new List<Departments>();
            while (reader.Read())
            {
                Departments dept = new Departments();
                dept.Id = Convert.ToInt32(reader["Id"]);
                dept.Name = reader["Name"].ToString();
                dept.Budget = Convert.ToSingle(reader["Budget"]);
                dept.StartDate = Convert.ToDateTime(reader["StartDate"]);
                dept.InstructorId = Convert.ToInt32(reader["InstructorId"]);
                dept.RowVersion = reader["RowVersion"].ToString();
                dept.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                dept.CreatedBy = reader["CreatedBy"].ToString();
                dept.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);
                dept.UpdatedBy = reader["UpdatedBy"].ToString();
                DepartmentList.Add(dept);
            }
            con.Close();

            cmd.Dispose();
            con.Dispose();
            return DepartmentList;
        }

        public Departments GetById(int id)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnection());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_GetByID_Dep";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Did", id);
            SqlDataReader reader = cmd.ExecuteReader();
            Departments dept = new Departments();
            while (reader.Read())
            {
                dept.Id = Convert.ToInt32(reader["Id"]);
                dept.Name = reader["Name"].ToString();
                dept.Budget = Convert.ToSingle(reader["Budget"]);
                dept.StartDate = Convert.ToDateTime(reader["StartDate"]);
                dept.InstructorId = Convert.ToInt32(reader["InstructorId"]);
                dept.RowVersion = reader["RowVersion"].ToString();
                dept.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                dept.CreatedBy = reader["CreatedBy"].ToString();
                dept.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);
                dept.UpdatedBy = reader["UpdatedBy"].ToString();
            }
            con.Close();

            cmd.Dispose();
            con.Dispose();
            return dept;
        }

        public void Update(Departments obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnection());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_Update_Dep";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@Did", obj.Id);
            cmd.Parameters.AddWithValue("@DName", obj.Name);
            cmd.Parameters.AddWithValue("@Dbudget", obj.Budget);
            cmd.Parameters.AddWithValue("@DStartDate", obj.StartDate);
            cmd.Parameters.AddWithValue("@DInstructorId", obj.InstructorId);
            cmd.Parameters.AddWithValue("@DRowVersion", obj.RowVersion);
            cmd.Parameters.AddWithValue("@DCreatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@DCreatedBy", obj.CreatedBy);
            cmd.Parameters.AddWithValue("@DUpdatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@DUpdatedBy", obj.UpdatedBy);

            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }
    }
}
