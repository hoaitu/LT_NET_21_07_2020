﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace bookhome
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "192.168.205.130";
            int port = 3306;
            string database = "simplehr";
            string username = "root";
            string password = "1234";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

    }
}