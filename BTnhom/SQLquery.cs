using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BTnhom
{
    class SQLquery
    {
        SqlConnection connect = null;
        string sqlconnect = "Data Source=THINKPADX1-CARB; Initial Catalog=student_management; Integrated Security = True";

        public void add(string id,string f_name, string l_name,DateTime date, string sex, string faculty)
        {
            if (connect==null)
            {
                connect = new SqlConnection(sqlconnect);
            }
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO dbo.student_information(ID,First_name,Last_name,Date_birth,Sex,Faculty_code) VALUES";
            command.Connection = connect;
        }

    }
}
