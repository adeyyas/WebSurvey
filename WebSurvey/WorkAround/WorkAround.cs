//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;

//namespace EmployeeApp
//{
//    class Employee
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Title { get; set; }

//        public void LogTime()
//        {
//            Console.WriteLine("Time logged for employee: " + Name);
//        }
//    }

//    class EmployeeManager
//    {
//        private string connectionString = "Server=(local);Database=TestDB;Trusted_Connection=True;";
//        private SqlConnection connection;

//        public EmployeeManager()
//        {
//            connection = new SqlConnection(connectionString);
//        }

//        public List<Employee> GetEmployees()
//        {
//            List<Employee> employees = new List<Employee>();

//            try
//            {
//                connection.Open();

//                SqlCommand command = new SqlCommand("SELECT * FROM Employee", connection);
//                SqlDataReader reader = command.ExecuteReader();

//                while (reader.Read())
//                {
//                    Employee employee = new Employee();
//                    employee.Id = (int)reader["Id"];
//                    employee.Name = reader["Name"].ToString();
//                    employee.Title = reader["Title"].ToString();

//                    employees.Add(employee);
//                }

//                reader.Close();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                connection.Close();
//            }

//            return employees;
//        }

//        public void AddEmployee(Employee employee)
//        {
//            try
//            {
//                connection.Open();

//                SqlCommand command = new SqlCommand("INSERT INTO Employee (Name, Title) VALUES (@Name, @Title)", connection);
//                command.Parameters.AddWithValue("@Name", employee.Name);
//                command.Parameters.AddWithValue("@Title", employee.Title);
//                command.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                connection.Close();
//            }
//        }

//        public void UpdateEmployee(Employee employee)
//        {
//            try
//            {
//                connection.Open();

//                SqlCommand command = new SqlCommand("UPDATE Employee SET Name=@Name, Title=@Title WHERE Id=@Id", connection);
//                command.Parameters.AddWithValue("@Name", employee.Name);
//                command.Parameters.AddWithValue("@Title", employee.Title);
//                command.Parameters.AddWithValue("@Id", employee.Id);
//                command.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                connection.Close();
//            }
//        }

//        public void DeleteEmployee(int id)
//        {
//            try
//            {
//                connection.Open();

//                SqlCommand command = new SqlCommand("DELETE FROM Employee WHERE Id=@Id", connection);
//                command.Parameters.AddWithValue("@Id", id);
//                command.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                connection.Close();
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create an employee object and add it to the database
//            Employee newEmployee = new Employee();
//            newEmployee.Name = "John Doe";
//            newEmployee.Title = "Software Developer";

//            EmployeeManager employeeManager = new EmployeeManager();
//            employeeManager.AddEmployee(newEmployee);

//            // Get all employees from the database and print their information
//            List<Employee> employees = employeeManager.GetEmployees();

//            foreach (Employee employee in employees)
//            {
//                Console.WriteLine("Id: " + employee.Id + ", Name: " + employee.Name; };
