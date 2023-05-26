using Microsoft.Data.SqlClient;
using Microsoft.Office.Interop.Word;
using RGZ_Info_systems.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_Info_systems.Controllers
{
    internal class TrainingController
    {
        private string Connection = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

        public void Update(Training training)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[UpdateTraining]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var par1 = new SqlParameter("@e_id", training.EmployeeNumber);
                var par2 = new SqlParameter("@c_id", training.CourseNumber);
                var par3 = new SqlParameter("@date_of_passage", training.DateOfPassage);


                connection.Open();
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);
                sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public void Delete(Training training)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[DeleteTraining]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var par1 = new SqlParameter("@c_id", training.CourseNumber);
                var par2 = new SqlParameter("@e_id", training.EmployeeNumber);

                connection.Open();
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public void Insert(Training training)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[InsertTraining]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var par1 = new SqlParameter("@e_id", training.EmployeeNumber);
                var par2 = new SqlParameter("@c_id", training.CourseNumber);
                var par3 = new SqlParameter("@date_of_passage", training.DateOfPassage);


                connection.Open();
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);
                sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public List<Training> GetTraining()
        {
            List<Training> list = new List<Training>();
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[SelectTraining]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var training = new Training();

                    training.CourseNumber = (int)reader["Номер курса"];
                    training.EmployeeNumber = (int)reader["Номер сотрудника"];
                    training.DateOfPassage = (DateTime)reader["Дата прохождения курса"];


                    list.Add(training);
                }
                reader.Close();
                connection.Close();
            }
            return list;
        }

        public List<string> GetPassedPeople()
        {
            var list = new List<string>();
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[GetPassedPeople]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string fname = (string)reader["fname"];
                    string lname = (string)reader["lname"];

                    list.Add(lname + " " + fname);
                }
                reader.Close();
                connection.Close();
            }
            return list;
        }

        public List<string> GetPassedPeopleYY()
        {
            var list = new List<string>();
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[GetPassedPeopleYY]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string fname = (string)reader["fname"];
                    string lname = (string)reader["lname"];

                    list.Add(lname + " " + fname);
                }
                reader.Close();
                connection.Close();
            }
            return list;
        }
    }
}
