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
    public class CourseRepository : IRepository<Courses>
    {
        public void Create(Courses obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnection());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_Create_Courses";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@CTitle", obj.Title);
            cmd.Parameters.AddWithValue("@CCredits", obj.Credits);
            cmd.Parameters.AddWithValue("@CDepartmentId", obj.DepartmentId);
            cmd.Parameters.AddWithValue("@CCreatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@CCreatedBy", obj.CreatedBy);
            cmd.Parameters.AddWithValue("@CUpdatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@CUpdatedBy", obj.UpdatedBy);

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
            cmd.CommandText = "SP_Delete_Courses";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }

        public List<Courses> GetAll()
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnection());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_GetAll_Courses";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataReader reader = cmd.ExecuteReader();
            List<Courses> CourseList = new List<Courses>();
            while (reader.Read())
            {
                Courses course = new Courses();
                course.Id = Convert.ToInt32(reader["Id"]);
                course.Title = reader["Title"].ToString();
                course.Credits = Convert.ToInt32(reader["Credits"]);
                course.DepartmentId = Convert.ToInt32(reader["DepartmentId"]);
                course.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                course.CreatedBy = reader["CreatedBy"].ToString();
                course.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);
                course.UpdatedBy = reader["UpdatedBy"].ToString();
                CourseList.Add(course);
            }
            con.Close();

            cmd.Dispose();
            con.Dispose();
            return CourseList;
        }

        public Courses GetById(int id)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnection());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_GetByID_Courses";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            Courses course = new Courses();

            while (reader.Read())
            {
                course.Id = Convert.ToInt32(reader["Id"]);
                course.Title = reader["Title"].ToString();
                course.Credits = Convert.ToInt32(reader["Credits"]);
                course.DepartmentId = Convert.ToInt32(reader["DepartmentId"]);
                course.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                course.CreatedBy = reader["CreatedBy"].ToString();
                course.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);
                course.UpdatedBy = reader["UpdatedBy"].ToString();

            }
            return course;
        }

        public void Update(Courses obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnection());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_Update_Courses";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@Cid", obj.Id);
            cmd.Parameters.AddWithValue("@CTitle", obj.Title);
            cmd.Parameters.AddWithValue("@CCredits", obj.Credits);
            cmd.Parameters.AddWithValue("@CDepartmentId", obj.DepartmentId);
            cmd.Parameters.AddWithValue("@CCreatedDate", obj.CreatedDate);
            cmd.Parameters.AddWithValue("@CCreatedBy", obj.CreatedBy);
            cmd.Parameters.AddWithValue("@CUpdatedDate", obj.UpdatedDate);
            cmd.Parameters.AddWithValue("@CUpdatedBy", obj.UpdatedBy);

            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }
    }
}
