﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DataAccessLibrary
{
    public class SqlliteDataAccess
    {
        public List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionString)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList();
                return rows;
            }
        }

        public void SaveData<T>(string sqlStatement, T parameters, string connectionString)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Execute(sqlStatement, parameters);
            }
        }

    }
}
