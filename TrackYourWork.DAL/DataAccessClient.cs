using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TrackYourWork.DAL
{
    public class DataAccessClient
    {
        public DataSet ExecuteStoredProc(string StoredPorc, string ConString, SqlParameter[] Parameters)
        {
            DataSet dsResult = new DataSet();
            using (SqlConnection sqlCon = new SqlConnection(ConString))
            {
                try
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = sqlCon.CreateCommand();
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.CommandText = StoredPorc;
                    sqlCmd.CommandTimeout = 1200;
                    foreach (SqlParameter Param in Parameters)
                    {
                        sqlCmd.Parameters.Add(Param);
                    }
                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                    sqlDa.Fill(dsResult);
                    return dsResult;
                }
                catch (Exception ex)
                {
                    //Logger.TextLogger log = new Logger.TextLogger();
                    //log.WriteLog(ex.ToString());
                    ////return null;
                    throw;
                }
                finally
                {
                    dsResult.Dispose();
                    sqlCon.Close();
                    sqlCon.Dispose();
                }
            }
        }

        public DataSet ExecuteQuery(string ConString, string Query)
        {
            DataSet dsResult = new DataSet();
            using (SqlConnection sqlCon = new SqlConnection(ConString))
            {
                try
                {
                    sqlCon.Open();
                    using (SqlCommand sqlCmd = sqlCon.CreateCommand())
                    {
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.CommandText = Query;
                        SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                        sqlDa.Fill(dsResult);
                    }
                    return dsResult;
                }
                catch (Exception ex)
                {
                    // return null;
                    throw;
                }
                finally
                {
                    dsResult.Dispose();
                    sqlCon.Close();
                    sqlCon.Dispose();
                }
            }
        }
    }

    
}

