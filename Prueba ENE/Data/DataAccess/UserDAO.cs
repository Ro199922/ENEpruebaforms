using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Prueba_ENE.model;
using Prueba_ENE.Data;
using System.Net;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Prueba_ENE.Data.DataAccess
{
    public class UserDAO
    {
        BDConnection connection = new BDConnection();

        public void CreateEmployee(Employee employee)
        {
            try
            {
                using (MySqlConnection connection = this.connection.ObtainConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO employee (RUT, name, address, phone, hourValue, extraValue," +
                        "grossSalary, netSalary, discountAFP, discountHealth, user_email) VALUES (@RUT, @name" +
                        ", @address, @phone, @hourValue, @extraValue,@grossSalary, @netSalary, @discountAFP, @discountHealth, @user_email)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue(parameterName: "@RUT", employee.RUT);
                    cmd.Parameters.AddWithValue(parameterName: "@name", employee.Name);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        public List<Employee> GetEmployees()
        {
           List<Employee> EmployeeList = new List<Employee>();
            
            using (MySqlConnection connection = this.connection.ObtainConnection())
            {
                connection.Open();
                string query = "SELECT RUT, name, adress, phone, user_email FROM employee";
                MySqlCommand cmd = new MySqlCommand( query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EmployeeList.Add(item: new Employee
                        {
                            RUT = reader["RUT"].ToString(),
                            Name = reader["name"].ToString(),
                            Address = reader["adress"].ToString(),
                            Phone = reader["phone"].ToString(),
                            UserEmail = reader["user_email"].ToString()
                        });
                    }
                }
                
            }
        }      
    }
}
