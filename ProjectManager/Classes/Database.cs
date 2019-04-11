using System;
using System.Data.SQLite;

namespace ProjectManager
{
    public static class Database
    {
        private static bool connectionIsOpen = false;
        private static readonly SQLiteConnection db_connect = new SQLiteConnection("Data Source=database.db;Version=3;");
        private static SQLiteCommand command;

        public static void TestConnection()
        {
            try
            {
                db_connect.Open();
                db_connect.Close();
                CstmMsgBx.Show("Database connect successfully", 4000);
            }
            catch (Exception exc)
            {
                CstmMsgBx.Error(exc.ToString(), 4000);
            }
        }

        private static void CheckConnectionStatus()
        {
            if (connectionIsOpen == true)
                db_connect.Close();
        }

        public static void RunSQL(string sql)
        {
            try
            {
                db_connect.Open();
                connectionIsOpen = true;
                command = new SQLiteCommand(sql, db_connect);
                command.ExecuteNonQuery();
                db_connect.Close();
            }
            catch (Exception exc)
            {
                Log.Error(Log.GetMethodName(), exc.ToString());
                CheckConnectionStatus();
            }
        }

        public static class Add
        {

        }

        public static class Read
        {

        }

        public static class Update
        {

        }

        public static class Delete
        {

        }
    }
}
