using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CURD_Core.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace CURD_Core.DATA
{
    public class IEmployeeClass : IEmployee
    {
        Model.Employee employee = new Employee();
        private readonly IOptions<Connection> _connection;


        public IEmployeeClass(IOptions<Connection> connection)
        {
            _connection = connection;
        }


        public DataSet GetData()
        {
            string con = _connection.Value.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(con);
            SqlCommand command = new SqlCommand("select * from Employees", sqlConnection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;

        }

        public DataSet GetDataId(int id)
        {
            string con = _connection.Value.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(con);
            SqlCommand command = new SqlCommand("select * from Employees where ID=" + id, sqlConnection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        public bool InsertData(Employee employee)
        {
            string con = _connection.Value.ConnectionString;

            try
            {


                SqlConnection sqlConnection = new SqlConnection(con);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("insert into Employees(FirstName,LastName,Gender,Salary) values(@FirstName,@LastName,@Gender,@Salary)", sqlConnection);
                command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                command.Parameters.AddWithValue("@Lastname", employee.LastName);
                command.Parameters.AddWithValue("@Gender", employee.Gender);
                command.Parameters.AddWithValue("@Salary", employee.Salary);

                int result = command.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {

            }
        }

        public bool UpdateData(int id, Employee employee)
        {
            string con = _connection.Value.ConnectionString;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(con);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("update Employees set FirstName=@name where ID=  " + id, sqlConnection);

                command.Parameters.AddWithValue("@id", employee.ID);
                command.Parameters.AddWithValue("@name", employee.FirstName);


                int result = command.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {

            }
        }

        public bool DeleteData(int id)
        {
            string con = _connection.Value.ConnectionString;
            try
            {
                Employee employee = new Employee();
                SqlConnection sqlConnection = new SqlConnection(con);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("delete from Employees where ID=" + id + " ", sqlConnection);

                int result = command.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
