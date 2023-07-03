using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;
using RGZ_Info_systems.Models;

namespace RGZ_Info_systems.Controllers
{
    public class CourseController
    {
        private string Connection = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        public CourseController() 
        {

        }

        public void Update(Course course)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[UpdCourse]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var par0 = new SqlParameter("@c_id", course.Id);
                var par1 = new SqlParameter("@name", course.Name);
                var par2 = new SqlParameter("@duration", course.Duration);
                var par3 = new SqlParameter("@purpose", course.Purpose);
                var par4 = new SqlParameter("@summary", course.Summary);


                connection.Open();
                sqlCommand.Parameters.Add(par0);
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);
                sqlCommand.Parameters.Add(par4);
                sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public void Delete(Course course)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[DeleteCourse]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var par1 = new SqlParameter("@c_id", course.Id);

                connection.Open();
                sqlCommand.Parameters.Add(par1);
                sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public void Insert(Course course)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[InsertCourse]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var par1 = new SqlParameter("@name", course.Name);
                var par2 = new SqlParameter("@duration", course.Duration);
                var par3 = new SqlParameter("@purpose", course.Purpose);
                var par4 = new SqlParameter("@summary", course.Summary);


                connection.Open();
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);    
                sqlCommand.Parameters.Add(par4);
                sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public List<Course> GetCourses()
        {
            List<Course> list = new List<Course>();
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[SelectCourse]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var course = new Course();

                    course.Id = (int)reader["Номер курса"];
                    course.Name = (string)reader["Название курса"];
                    course.Duration = (int)reader["Длительность"];
                    course.Purpose = (int)reader["Отдел"];
                    course.Summary = (string)reader["Описание"];

                    list.Add(course);
                }
                reader.Close();
                connection.Close();
            }
            return list;
        }


        public int GetTimeCourses()
        {
            int time = 0;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[GetTimeCourses]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    time = (int)reader["Count"];
                }
                reader.Close();
                connection.Close();
            }
            return time;
        }


        public int GetCountCourses()
        {
            int time = 0;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[GetCountCourses]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    time = (int)reader["Count"];
                }
                reader.Close();
                connection.Close();
            }
            return time;
        }
    }
}
