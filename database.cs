
using System;
using System.Data.OleDb;
using System.IO;

namespace ACT3
{
    public class Database
    {
        private static readonly string databasePath =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "sampledb.accdb"
            );

        private static readonly string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            databasePath +
            ";Persist Security Info=False;";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }
    }
}
