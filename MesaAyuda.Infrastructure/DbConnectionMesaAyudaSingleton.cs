using System.Data.Odbc;

namespace  MesaAyuda.Infrastructure
{
    public class DbConnectionMesaAyudaSingleton
    {
        private static DbConnectionMesaAyudaSingleton dbInstance;
        private readonly OdbcConnection conn;

        private DbConnectionMesaAyudaSingleton()
        {
            string connectionString = @"Driver={SQL Server};Server=elfprd02;Databse=Mesa_de_Ayuda;Uid=usrmesa;Pwd=ayu;";

            conn = new OdbcConnection(connectionString);
        }

        public static DbConnectionMesaAyudaSingleton getDbInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new DbConnectionMesaAyudaSingleton();
            }
            return dbInstance;
        }

        public OdbcConnection GetDBConnection()
        {
            return conn;
        }

        public void CloseDBConnection()
        {
            conn.Close();
        }
    }
}