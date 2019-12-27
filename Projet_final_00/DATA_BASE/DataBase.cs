using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Projet_final_00.DATA_BASE
{
    class DataBase
    {
        MySqlConnection mysqlconnection;

        public DataBase()
        {
            mysqlconnection = new MySqlConnection("Server="+ Properties.Settings.Default.Server + "; Port="+ 
                Properties.Settings.Default.Port + "; DataBase="+ Properties.Settings.Default.Database + "; uid="+ 
                Properties.Settings.Default.User + "; passowrd="+ Properties.Settings.Default.Password + "");
        }
        public void Open()
        {
            if (mysqlconnection.State != ConnectionState.Open)
            {
                mysqlconnection.Open();
            }
        }
        public void Close()
        {
            if (mysqlconnection.State == ConnectionState.Open)
            {
                mysqlconnection.Close();
            }
        }
        public DataTable SelectData(string stored_procedure, MySqlParameter[] param)
        {
            MySqlCommand mysqlcmd = new MySqlCommand();
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.CommandText = stored_procedure;
            mysqlcmd.Connection = mysqlconnection;

            if (param != null)
            {
                mysqlcmd.Parameters.AddRange(param);
            }
            MySqlDataAdapter da = new MySqlDataAdapter(mysqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public void ExecuteCommand(string stored_procedure, MySqlParameter[] param)
        {
            MySqlCommand mysqlcmd = new MySqlCommand();
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.CommandText = stored_procedure;
            mysqlcmd.Connection = mysqlconnection;

            if (param != null)
            {
                mysqlcmd.Parameters.AddRange(param);
            }
            mysqlcmd.ExecuteNonQuery();
        }
    }
}
