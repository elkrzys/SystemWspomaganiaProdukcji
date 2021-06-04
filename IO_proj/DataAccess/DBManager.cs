using MySql.Data.MySqlClient;
using ProductionManagementSystem.Models;
using ProductionManagementSystem.Security;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProductionManagementSystem.DataAccess
{
    //Singleton pattern
    public class DBManager
    {

        #region private members

        private MySqlConnection connection;
        private static DBManager instance = null;
        private static readonly object synclock = new object();
        private static readonly string connectionString = "Server=remotemysql.com;Port=3306;Database=jpcfvyP3J2;Uid=jpcfvyP3J2;Pwd=is9ERbctyf;";

        #endregion

        #region constructors

        protected DBManager()
        {
            connection = new MySqlConnection(connectionString);
        }

        #endregion

        #region public properties and methods

        public static DBManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synclock)
                    {
                        if (instance == null) instance = new DBManager();
                    }
                }
                return instance;
            }
        }

        public void Ping()
        {
            //TODO
        }


        public int GetUserId(string login, string hashedPassword)
        {
            connection.Open();

            var statement = $"SELECT user_id FROM employee_credentials WHERE login = '{login}' AND password = '{hashedPassword}'";
            var command = new MySqlCommand(statement, connection);
            try
            {
                int userId = -1;
                var reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    connection.Close();
                    return -4;
                }
                while (reader.Read())
                {
                    userId = reader.GetInt32("user_id");
                }
                connection.Close();
                return userId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
            }
            return -3;
        }

        public int GetUserIdByPesel(string pesel)
        {
            connection.Open();

            int userId = (int)StatusCode.PeselNotFound;

            var statement = $"SELECT user_id FROM employees WHERE pesel = '{pesel}'";
            var command = new MySqlCommand(statement, connection);
            try
            {
                var reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    connection.Close();
                    return userId;
                }
                while (reader.Read())
                {
                    userId = reader.GetInt32("user_id");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
            }

            connection.Close();

            return userId;
        }

        public int InsertUserCredentials(int userId, string login, string password)
        {
            connection.Open();

            var statement = $"INSERT INTO employee_credentials VALUES ({userId}, '{login}', '{password}')";
            var command = new MySqlCommand(statement, connection);
            try
            {
                if (command.ExecuteNonQuery() != 1)
                {
                    connection.Close();
                    return -3;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
                return -3;
            }

            connection.Close();

            return 0;
        }

        public bool LoginExists(string login)
        {
            connection.Open();

            var statement = $"SELECT COUNT(*) FROM employee_credentials WHERE login = '{login}'";
            var command = new MySqlCommand(statement, connection);

            try
            {
                int result = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                if (result > 0) return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
            }

            connection.Close();

            return false;
        }

        public Employee GetUserById(int id)
        {
            connection.Open();

            var statement = $"SELECT * FROM employees WHERE user_id = '{id}'";
            var command = new MySqlCommand(statement, connection);


            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();

                var employee = new Employee
                {
                    UserId = reader.GetInt32(0),
                    TypeId = reader.GetInt32(1),
                    Name = reader.GetString(2),
                    LastName = reader.GetString(3),
                    Pesel = reader.GetString(4),
                    DateOfBirth = reader.GetDateTime(5),
                    PlaceOfResidence = reader.GetString(6),
                    DepartmentId = reader.GetInt32(7)
                };

                reader.Close();
                connection.Close();
                return employee;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message, "Błąd");
                Console.WriteLine(e.Message);
            }

            connection.Close();
            return null;
        }

        public bool InsertUserStatistics(WorkerStatistics stats)
        {
            return false;
        }

        public int InsertEmployeeForm(DateTime date, int createdParts)
        {
            connection.Open();

            Employee currentUser = global.GetInstance().GetCurrentUser();
            var workerStatInsertion = $"INSERT INTO worker_statistics (amount,user_id,department_id,date,norm,prize_points) VALUES ({createdParts},{currentUser.UserId},{currentUser.DepartmentId},'{date.ToString("yyyy-MM-dd")}',{0},{0})";
            var command = new MySqlCommand(workerStatInsertion, connection);
            try
            {
                if (command.ExecuteNonQuery() != 1)
                {
                    connection.Close();
                    return -3;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
                return -3;
            }
            connection.Close();

            return 0;
        }
        public int GetEmployeeForm()
        {
            connection.Open();
            Employee currentEmployee = global.GetInstance().GetCurrentUser();
            List<EmployeeForm> tmpFormList = new List<EmployeeForm>();
            var workerStatInsertion = $"SELECT * FROM worker_statistics WHERE user_id = {currentEmployee.UserId}";
            MySqlCommand command = new MySqlCommand(workerStatInsertion, connection);
            try
            {
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeForm tmpEmpForm = new EmployeeForm();
                    tmpEmpForm.date = reader.GetString(2);                     //date
                    tmpEmpForm.date = tmpEmpForm.date.Remove(10);
                    tmpEmpForm.amount = Int32.Parse(reader.GetString(3));     //amount
                    tmpEmpForm.norm = Int32.Parse(reader.GetString(4));       //norm
                    tmpEmpForm.prizePoints = Int32.Parse(reader.GetString(5));//prize

                    tmpFormList.Add(tmpEmpForm);
                }

                global.GetInstance().GetCurrentUser().SetFormList(tmpFormList);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
                return -3;
            }
            connection.Close();

            return 0;
        }


        public Department GetDepartmentManagerData(int departmentId)
        {
            connection.Open();
            Employee currentEmployee = global.GetInstance().GetCurrentUser();
            List<EmployeeForm> tmpFormList = new List<EmployeeForm>();
            var workerStatInsertion = $"SELECT * FROM departments WHERE department_id = {currentEmployee.DepartmentId}";
            MySqlCommand command = new MySqlCommand(workerStatInsertion, connection);

            var reader = command.ExecuteReader();
            reader.Read();
            Department userDepartment = new Department();
            userDepartment.departmentId = reader.GetInt32(0);    //department id                 
            userDepartment.departmentName = reader.GetString(1); // department name
            userDepartment.partId = reader.GetInt32(2);          // part id 
            
            connection.Close();
            return userDepartment;

            

        }

        public List<Employee> GetEmployeesList(int departmentId)
        {
            connection.Open();
            List<Employee> newList = new List<Employee>();

            var workerStatInsertion = $"SELECT * FROM employees WHERE department_id = {departmentId} and type_id = {3}";
            MySqlCommand command = new MySqlCommand(workerStatInsertion, connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var employee = new Employee
                {
                    UserId = reader.GetInt32(0),
                    TypeId = reader.GetInt32(1),
                    Name = reader.GetString(2),
                    LastName = reader.GetString(3),
                    Pesel = reader.GetString(4),
                    DateOfBirth = reader.GetDateTime(5),
                    PlaceOfResidence = reader.GetString(6),
                    DepartmentId = reader.GetInt32(7)
                };

               // employee.SetFormList();

                newList.Add(employee);
            }
            connection.Close();
            return newList;

        }

        public List<EmployeeForm> GetEmployeeForm(int userId)
        {
            connection.Open();
        
            List<EmployeeForm> tmpFormList = new List<EmployeeForm>();
            var workerStatInsertion = $"SELECT * FROM worker_statistics WHERE user_id = {userId}";
            MySqlCommand command = new MySqlCommand(workerStatInsertion, connection);
          
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeForm tmpEmpForm = new EmployeeForm();
                    tmpEmpForm.date = reader.GetString(2);                     //date
                    tmpEmpForm.date = tmpEmpForm.date.Remove(10);
                    tmpEmpForm.amount = Int32.Parse(reader.GetString(3));     //amount
                    tmpEmpForm.norm = Int32.Parse(reader.GetString(4));       //norm
                    tmpEmpForm.prizePoints = Int32.Parse(reader.GetString(5));//prize

                    tmpFormList.Add(tmpEmpForm);
                }

            connection.Close();
            return tmpFormList;
                

         
        }
        #endregion
    }
}
