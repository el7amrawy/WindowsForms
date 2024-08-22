using System.Data;
using System.Data.SqlClient;

namespace Day4_Task1
{
    internal static class ADO
    {
        private const string _connectionString = "Data Source=.;Initial Catalog=MYDB;Integrated Security=True;";
        static internal List<Employee> GetEmployees()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_GetEmployees", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                List<Employee> emps = new List<Employee>();
                while (dr.Read()) {
                    if ((string)dr["Type"] == MyTypes.Employee.ToString())
                        emps.Add(new Employee()
                        {
                            Id=(int)dr["Id"],
                            FirstName = (string)dr["FirstName"],
                            LastName = (string)dr["LastName"],
                            Password = (string)dr["Password"],
                            BirthDay = (DateTime)dr["BirthDay"],
                            Gender = (string)dr["Gender"],
                            Mstatus = (string)dr["Mstatus"],
                            Habits = (string)dr["Habits"],
                            EnglishLang = (byte)dr["EnglishLang"],
                            ArabicLang = (byte)dr["ArabicLang"],
                            Salary = (decimal)dr["Salary"],
                            Job = (string)dr["Job"],
                            Type = (string)dr["Type"]
                        });
                    else if ((string)dr["Type"] == MyTypes.Manager.ToString())
                        emps.Add(new Manager()
                        {
                            Id = (int)dr["Id"],
                            FirstName = (string)dr["FirstName"],
                            LastName = (string)dr["LastName"],
                            Password = (string)dr["Password"],
                            BirthDay = (DateTime)dr["BirthDay"],
                            Gender = (string)dr["Gender"],
                            Mstatus = (string)dr["Mstatus"],
                            Habits = (string)dr["Habits"],
                            EnglishLang = (byte)dr["EnglishLang"],
                            ArabicLang = (byte)dr["ArabicLang"],
                            Salary = (decimal)dr["Salary"],
                            Job = (string)dr["Job"],
                            Department = (string)dr["Department"],
                            Type = (string)dr["Type"]
                        });
                }
                dr.Close();
                conn.Close();
                return emps;
            }
        }
        static internal void AddEmployee(Employee employee)
        {
            using (SqlConnection conn=new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand( "SP_AddEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = employee.FirstName;
                cmd.Parameters.Add("@LastName",SqlDbType.VarChar).Value=employee.LastName;
                cmd.Parameters.Add("@BirthDay",SqlDbType.DateTime).Value=employee.BirthDay;
                cmd.Parameters.Add("@Gender",SqlDbType.VarChar).Value=employee.Gender;
                cmd.Parameters.Add("@Mstatus",SqlDbType.NVarChar).Value=employee.Mstatus;
                cmd.Parameters.Add("@Habits",SqlDbType.VarChar).Value=employee.Habits;
                cmd.Parameters.Add("@EnglishLang", SqlDbType.TinyInt).Value = employee.EnglishLang;
                cmd.Parameters.Add("@ArabicLang", SqlDbType.TinyInt).Value = employee.ArabicLang;
                cmd.Parameters.Add("@Password",SqlDbType.VarChar).Value=employee.Password;
                cmd.Parameters.Add("@Salary", SqlDbType.Decimal).Value = employee.Salary;
                cmd.Parameters.Add("@Job", SqlDbType.VarChar).Value = employee.Job;
                cmd.Parameters.Add("@Type",SqlDbType.VarChar).Value=employee.Type;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        static internal void AddEmployee(Manager employee)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_AddManager", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = employee.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = employee.LastName;
                cmd.Parameters.Add("@BirthDay", SqlDbType.DateTime).Value = employee.BirthDay;
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = employee.Gender;
                cmd.Parameters.Add("@Mstatus", SqlDbType.NVarChar).Value = employee.Mstatus;
                cmd.Parameters.Add("@Habits", SqlDbType.VarChar).Value = employee.Habits;
                cmd.Parameters.Add("@EnglishLang", SqlDbType.TinyInt).Value = employee.EnglishLang;
                cmd.Parameters.Add("@ArabicLang", SqlDbType.TinyInt).Value = employee.ArabicLang;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = employee.Password;
                cmd.Parameters.Add("@Salary", SqlDbType.Decimal).Value = employee.Salary;
                cmd.Parameters.Add("@Job", SqlDbType.VarChar).Value = employee.Job;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = employee.Type;
                cmd.Parameters.Add("@Department",SqlDbType.NVarChar).Value = employee.Department;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
