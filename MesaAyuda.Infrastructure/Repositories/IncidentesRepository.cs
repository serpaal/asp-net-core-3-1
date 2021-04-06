using MesaAyuda.Domain.Entities;
using MesaAyuda.Domain.Repositories;
using MesaAyuda.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace MesaAyuda.Infrastructure.Repositories
{
    public class IncidentesRepository : IIncidentesRepository
    {
        private DbConnectionMesaAyudaSingleton _db;        

        public IEnumerable<IncidentesInfo> GetIncidentes(string cod_u_rbl = "VBUS01")
        {           
           var user = cod_u_rbl;
           var result = new List<IncidentesInfo>();
            try
            {
                _db = DbConnectionMesaAyudaSingleton.getDbInstance();
                _db.GetDBConnection().Open();
                using (var cmd = _db.GetDBConnection().CreateCommand())
                {
                    string sql = $@"SELECT 
                                    i.[nro_inc],
                                    i.[fecha_sol],
                                    u.[nomb_comp],
                                    i.[arch_adj],
                                    i.[observ],
                                    d.[descrip],
                                    d.[estado],
                                    d.[cod_u_rbl]
                                    FROM 
                                    [Mesa_de_Ayuda].[dbo].[INCIDENTES_INF] i,
                                    [Mesa_de_Ayuda].[dbo].[INC_DETALLE] d,
                                    [Mesa_de_Ayuda].[dbo].[USUARIOS] u
                                    INNER JOIN  [Mesa_de_Ayuda].[dbo].[USR_PERFILES] p
                                    ON p.login = u.login
                                    WHERE i.[nro_inc] = d.[nro_inc] 
                                    AND i.[cod_usr] = p.[cod_usr] 
                                    AND d.[cod_u_rbl] = '{cod_u_rbl}' 
                                    AND d.[estado] in ('N', 'R', 'Z')
                                    ORDER BY i.[fecha_sol] ASC";


                    cmd.CommandText = sql;
                    OdbcDataReader dataReader;
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var incidente = new IncidentesInfo {
                            nro_inc = dataReader.SafeGetString(0),
                            fecha_sol = dataReader.SafeGetDate(1),
                            nomb_comp = dataReader.SafeGetString(2),
                            arch_adj = dataReader.SafeGetString(3),
                            observ = dataReader.SafeGetString(4),
                            descrip = dataReader.SafeGetString(5),
                            estado = dataReader.SafeGetString(6),
                            cod_u_rbl = dataReader.SafeGetString(7)                           
                        };                                               
                        result.Add(incidente);  
                    }                    
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _db.CloseDBConnection();
            }           
        }      
    }
}
