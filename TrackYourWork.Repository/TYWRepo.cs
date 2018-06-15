using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using TrackYourWork.DAL;
using System.Data.SqlClient;

namespace TrackYourWork.Repository
{
    public class TYWRepo
    {
        #region Properties
        private string ConnectionString
        { get { return Convert.ToString(System.Configuration.ConfigurationManager.ConnectionStrings["CNTYW"].ConnectionString); } }
        #endregion

        public string CreateNewTicket(string emailId, string ticketDesc, string ticketType)
        {
            StringBuilder strResult = new StringBuilder();
            DataSet DataInserted = new DataSet();
            DataAccessClient client = new DataAccessClient();
            string spname = "[dbo].[uspInsertNewTicket]";

            SqlParameter[] paramsall = new SqlParameter[3];

            SqlParameter spmEmaildId = new SqlParameter("@emailId", SqlDbType.NVarChar, 100);
            spmEmaildId.Value = emailId;

            SqlParameter spmTickDesc = new SqlParameter("@ticketDesc", SqlDbType.NVarChar, 4000);
            spmTickDesc.Value = ticketDesc;

            SqlParameter spmTicketType = new SqlParameter("@ticketType", SqlDbType.NVarChar, 15);
            spmTicketType.Value = ticketType;

            paramsall[0] = spmEmaildId;
            paramsall[1] = spmTickDesc;
            paramsall[2] = spmTicketType;

            DataInserted = client.ExecuteStoredProc(spname, ConnectionString, paramsall);

            return string.Empty;
        }
    }
}
