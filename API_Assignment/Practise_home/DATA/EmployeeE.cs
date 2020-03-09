using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Practise_home.DB;

namespace Practise_home.DATA
{
    public class EmployeeE
    {

        string ConnectionString = ConfigurationManager.ConnectionStrings["API_Prac"].ConnectionString;
        public DataSet GetData()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("select * from Employees", sqlConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;

            }
        }


        public DataSet GetData(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                Practise_home.DB.Employee emp = new Practise_home.DB.Employee();
                SqlCommand command = new SqlCommand("select * from Employees where ID=" + id + " ", sqlConnection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;

            }
        }
        public bool InsertEmp(Employee emp)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                //Practise_home.DB.Employee emp = new Practise_home.DB.Employee();
                SqlCommand cmd = new SqlCommand("sp_insert_values", sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@lastName", emp.LastName);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);


                int result = cmd.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;
                else
                    return false;

            }
        }
        public bool UpdateData(int id, Employee emp)
        {
            try
            {

                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                
                //SqlCommand command = new SqlCommand("Update Employees Set FirstName=@FirstName where ID=" + id, sqlConnection);
                
                //command.Parameters.AddWithValue("@FirstName", emp.FirstName);
                //command.Parameters.AddWithValue("@Emp_id", emp.ID);

                SqlCommand command = new SqlCommand("sp_update_values", sqlConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FirstName", emp.FirstName);
                command.Parameters.AddWithValue("@LastName", emp.LastName);
                command.Parameters.AddWithValue("@Emp_id", id);

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
        public bool DeleteEmp(int id)
        {
            try
            {
                Employee emp = new Employee();
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                //SqlCommand command = new SqlCommand("delete from Employees where ID=" + id + " ", sqlConnection);

                //int result = command.ExecuteNonQuery();

                SqlCommand command = new SqlCommand("sp_delete_values", sqlConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmpId", id);
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