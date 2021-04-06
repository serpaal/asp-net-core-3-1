using System;
using System.Data.Odbc;

namespace MesaAyuda.Infrastructure.Extensions
{
    public static class SafeGetMethods
    {
        public static string SafeGetString(this OdbcDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return string.Empty;
        }
        public static int SafeGetInt(this OdbcDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetInt32(colIndex);
            return 0;
        }
        public static double SafeGetDouble(this OdbcDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetDouble(colIndex);
            return 0;
        }
        public static DateTime SafeGetDate(this OdbcDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetDateTime(colIndex);
            return new DateTime();
        }
        public static bool SafeGetBool(this OdbcDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetBoolean(colIndex);
            return false;

        }
    }

}
