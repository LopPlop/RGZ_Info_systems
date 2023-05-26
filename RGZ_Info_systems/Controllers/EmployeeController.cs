using Microsoft.Data.SqlClient;
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
    class EmployeeController
    {
        private string Connection = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

        public EmployeeController()
        {

        }

        public void Update(Models.Employee employee)
        {
            using(SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[UpdEmp]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var par0 = new SqlParameter("@emp_id", employee.Id);
                var par1 = new SqlParameter("@fname", employee.FirstName);
                var par2 = new SqlParameter("@lname", employee.LastName);
                var par3 = new SqlParameter("@pos_num", employee.Position);
                var par4 = new SqlParameter("@dep_num", employee.Department);
                var par5 = new SqlParameter("@emp_date", employee.EmploymentDate);


                connection.Open();
                sqlCommand.Parameters.Add(par0);
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);
                sqlCommand.Parameters.Add(par4);
                sqlCommand.Parameters.Add(par5);
                sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public void Delete(Models.Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[DeleteEmp]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var par1 = new SqlParameter("@emp_id", employee.Id);


                connection.Open();
                sqlCommand.Parameters.Add(par1);
                sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public void Insert(Models.Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[InsertEmp]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var par1 = new SqlParameter("@fname", employee.FirstName);
                var par2 = new SqlParameter("@lname", employee.LastName);
                var par3 = new SqlParameter("@pos_num", employee.Position);
                var par4 = new SqlParameter("@dep_num", employee.Department);
                var par5 = new SqlParameter("@emp_date", employee.EmploymentDate);


                connection.Open();
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);
                sqlCommand.Parameters.Add(par4);
                sqlCommand.Parameters.Add(par5);
                sqlCommand.ExecuteReader();
                connection.Close();
            }
        }


        public List<Employee> GetEmployees()
        {
            List<Employee> list = new List<Employee>();
            using(SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[SelectEmployee]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var employee = new Employee();

                    employee.Id = (int)reader["Номер сотрудника"];
                    employee.FirstName = (string)reader["Имя"];
                    employee.LastName = (string)reader["Фамилия"];
                    employee.Position = (int)reader["Должность"];
                    employee.EmploymentDate = (DateTime)reader["Дата принятия на работу"];

                    list.Add(employee);
                }
                reader.Close();
                connection.Close();
            }
            return list;
        }

        public List<JoinedObject> SelectAllTables()
        {
            List<JoinedObject> list = new List<JoinedObject>();
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                string proc = "[dbo].[SelectAll]";
                SqlCommand sqlCommand = new SqlCommand(proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var joinedObj = new JoinedObject();

                    joinedObj.DateOfPassage = (DateTime)reader["date_of_passage"];
                    joinedObj.EmpId = (int)reader["emp_id"];
                    joinedObj.FirstName = (string)reader["fname"];
                    joinedObj.LastName = (string)reader["lname"];
                    joinedObj.Position = (int)reader["pos_num"];
                    joinedObj.EmployeeDate = (DateTime)reader["emp_date"];
                    joinedObj.CourseName = (string)reader["name"];
                    joinedObj.CourseId = (int)reader["c_id"];
                    joinedObj.Duration = (int)reader["duration"];
                    joinedObj.Purpose = (int)reader["purpose"];
                    joinedObj.Summary = (decimal)reader["summary"];

                    list.Add(joinedObj);
                }
                reader.Close();
                connection.Close();
            }
            return list;
        }
    }
}
