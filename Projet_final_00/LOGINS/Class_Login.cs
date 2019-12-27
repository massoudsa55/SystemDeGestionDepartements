using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projet_final_00.LOGINS
{
    class Class_Login
    {
        public DataTable LOGIN(string ID, string PWD, string Type)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[3];

            param[0] = new MySqlParameter("@username", MySqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new MySqlParameter("@password", MySqlDbType.VarChar, 50);
            param[1].Value = PWD;

            param[2] = new MySqlParameter("@type_user", MySqlDbType.VarChar, 50);
            param[2].Value = Type;

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_LOGIN", param);
            db.Close();
            return dt;
        }
    }
}
