using System;
using System.Collections.Generic;
using System.Data.Odbc;
using MesaAyuda.Domain.Entities;
using MesaAyuda.Domain.Repositories;
using MesaAyuda.Infrastructure.Extensions;

namespace MesaAyuda.Infrastructure.Repositories
{
    public class RequerimientosRepository : IRequerimientosRepository
    {
        private DbConnectionMesaAyudaSingleton _db;        
        
        public IEnumerable<RequerimientoInfo> GetRequerimientos(string cod_u_rbl)
        {           
            var user = cod_u_rbl;          
            try {
                var result = new List<RequerimientoInfo>();
                _db = DbConnectionMesaAyudaSingleton.getDbInstance();
                _db.GetDBConnection().Open();
                using (var cmd = _db.GetDBConnection().CreateCommand())
                {
                    string sql = $@"SELECT 
                                    r.[nro_req], 
                                    r.[fecha_sol], 
                                    u.[nomb_comp], 
                                    r.[cod_usr], 
                                    r.[cod_vinc], 
                                    r.[cod_area], 
                                    r.[proyecto], 
                                    q.[cod_u_rbl],  
                                    r.[fecha_cierre], 
                                    r.[cod_u_rcp], 
                                    r.[observ], 
                                    r.[arch_adj],  
                                    q.[descrip_req], 
                                    q.[justific], 
                                    q.[estado] 
                                    FROM  
                                    [Mesa_de_Ayuda].[dbo].[REQUERIM_INF] r, 
                                    [Mesa_de_Ayuda].[dbo].[REQ_QDETALLE] q,  
                                    [Mesa_de_Ayuda].[dbo].[USUARIOS] u 
                                    INNER JOIN  [Mesa_de_Ayuda].[dbo].[USR_PERFILES] p 
                                    ON p.[login] = u.[login]
                                    WHERE r.[nro_req] = q.[nro_req] 
                                    AND r.[cod_usr] = p.[cod_usr] 
                                    AND q.[cod_u_rbl] = '{cod_u_rbl}'  
                                    AND q.[estado] IN ('N', 'R', 'Z') 
                                    ORDER BY r.[fecha_sol] ASC";

                    cmd.CommandText = sql;
                    OdbcDataReader dataReader;
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var requerimiento = new RequerimientoInfo {
                            nro_req = dataReader.SafeGetString(0),
                            fecha_sol = dataReader.SafeGetDate(1),
                            nomb_comp = dataReader.SafeGetString(2),
                            cod_usr = dataReader.SafeGetString(3),
                            cod_vinc = dataReader.SafeGetString(4),
                            cod_area = dataReader.SafeGetString(5),
                            proyecto = dataReader.SafeGetString(6),
                            cod_u_rbl = dataReader.SafeGetString(7),
                            fecha_cierre = dataReader.SafeGetDate(8),
                            cod_u_rcp = dataReader.SafeGetString(9),
                            observ = dataReader.SafeGetString(10),
                            arch_adj = dataReader.SafeGetString(11),
                            descrip_req = dataReader.SafeGetString(12),
                            justific = dataReader.SafeGetString(13),   
                            estado = dataReader.SafeGetString(14)                                        
                        };                                               
                        result.Add(requerimiento);  
                    }                    
                }
                return result;
            } 
            catch(Exception){
                throw;
            }
            finally {
                _db.CloseDBConnection();
            }
          
        }
       
    }
}
