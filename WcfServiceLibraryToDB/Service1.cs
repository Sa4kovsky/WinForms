using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceLibraryToDB.Models;

namespace WcfServiceLibraryToDB
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        public Service1()
        {
            ConnectToBd();
        }

        void ConnectToBd()
        {
            sqlConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=TaskBD;");
            sqlCommand = sqlConnection.CreateCommand();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Staff> GetStaff()
        {
            List<Staff> allStaff = new List<Staff>();
            try
            {
                sqlCommand.CommandText = "SELECT * FROM Staff";
                sqlCommand.CommandType = CommandType.Text;
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    allStaff.Add(new Staff(Convert.ToInt32(reader[0]), reader[1].ToString(), 
                        reader[2].ToString(), reader[3].ToString()));
                }
               return allStaff;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        public int InsertStaff(Staff staff)
        {
            try
            {
                sqlCommand.CommandText = "INSERT INTO Staff VALUES(@Surname, @Name, @Patronymic)";
                sqlCommand.Parameters.AddWithValue("Surname", staff.Surname);
                sqlCommand.Parameters.AddWithValue("Name", staff.Name);
                sqlCommand.Parameters.AddWithValue("Patronymic", staff.Patronymic);

                sqlCommand.CommandType = CommandType.Text;

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        public int UpdateStaff(Staff staff)
        {
            try
            {
                sqlCommand.CommandText = "UPDATE Staff SET Surname=@Surname, Name=@Name, Patronymic=@Patronymic WHERE StaffId=@StaffId";
                sqlCommand.Parameters.AddWithValue("StaffId", staff.StaffId);
                sqlCommand.Parameters.AddWithValue("Surname", staff.Surname);
                sqlCommand.Parameters.AddWithValue("Name", staff.Name);
                sqlCommand.Parameters.AddWithValue("Patronymic", staff.Patronymic);

                sqlCommand.CommandType = CommandType.Text;

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        public int DeletetStaff(Staff staff)
        {
            try
            {
                sqlCommand.CommandText = "DELETE Staff WHERE StaffId=@StaffId";
                sqlCommand.Parameters.AddWithValue("StaffId", staff.StaffId);

                sqlCommand.CommandType = CommandType.Text;

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        public List<Task> GetTasks()
        {
            List<Task> allTask = new List<Task>();
            try
            {
                sqlCommand.CommandText = @"SELECT Task.TaskId, Task.NameTask, 
                                            Task.WorkLoad, Task.StartDate, Task.ExpiryDate, Task.Status,
                                            CONCAT(Staff.Surname, ' ', Staff.Name, ' ', Staff.Patronymic) as Staff
                                            FROM Task
                                            LEFT JOIN Staff
                                            ON Task.StaffId = Staff.StaffId";
                sqlCommand.CommandType = CommandType.Text;
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    allTask.Add(new Task(Convert.ToInt32(reader[0]), reader[1].ToString(),
                        Convert.ToInt32(reader[2]), Convert.ToDateTime(reader[3]), Convert.ToDateTime(reader[4]),
                        reader[5].ToString(), reader[6].ToString()));
                }
                return allTask;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        public int InsertTask(Task task)
        {
            try
            {
                sqlCommand.CommandText = "INSERT INTO Task VALUES(@NameTask, @WorkLoad, @StartDate, @ExpiryDate, @Status, @StaffId)";
                sqlCommand.Parameters.AddWithValue("NameTask", task.NameTask);
                sqlCommand.Parameters.AddWithValue("WorkLoad", task.Workload);
                sqlCommand.Parameters.AddWithValue("StartDate", task.StartDate);
                sqlCommand.Parameters.AddWithValue("ExpiryDate", task.ExpiryDate);
                sqlCommand.Parameters.AddWithValue("Status", task.Status);
                sqlCommand.Parameters.AddWithValue("StaffId", Convert.ToInt32(task.Staff));

                sqlCommand.CommandType = CommandType.Text;

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        public int UpdateTask(Task task)
        {
            try
            {
                sqlCommand.CommandText = @"UPDATE Task SET  NameTask=@NameTask, WorkLoad=@WorkLoad, StartDate=@StartDate, 
                                           ExpiryDate=@ExpiryDate, Status=@Status, StaffId=@StaffId WHERE TaskId=@TaskId";
                sqlCommand.Parameters.AddWithValue("TaskId", task.TaskId);
                sqlCommand.Parameters.AddWithValue("NameTask", task.NameTask);
                sqlCommand.Parameters.AddWithValue("WorkLoad", task.Workload);
                sqlCommand.Parameters.AddWithValue("StartDate", task.StartDate);
                sqlCommand.Parameters.AddWithValue("ExpiryDate", task.ExpiryDate);
                sqlCommand.Parameters.AddWithValue("Status", task.Status);
                sqlCommand.Parameters.AddWithValue("StaffId", Convert.ToInt32(task.Staff));

                sqlCommand.CommandType = CommandType.Text;

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        public int DeletetTask(Task task)
        {
            try
            {
                sqlCommand.CommandText = "DELETE Task WHERE TaskId=@TaskId";
                sqlCommand.Parameters.AddWithValue("TaskId", task.TaskId);

                sqlCommand.CommandType = CommandType.Text;

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
