#region References
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Logger
{
    public class TextLogger
    {
        #region Properties
        private string GetLogFilePath
        { get { return Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["LogFilePath"]); } }
        private string GetLogFileName
        { get { return Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["LogFileName"]); } }
        #endregion

        #region Functions/Methods
        /// <summary>
        /// Writting text log.
        /// </summary>
        /// <param name="strLogText"></param>
        public void WriteLog(string strLogText)
        {
            string LogFile = GetLogFilePath + GetLogFileName + "_" + DateTime.Today.ToString("yyyyMMdd") + ".txt";
            StreamWriter log;
            if (!File.Exists(LogFile))
            { log = new StreamWriter(LogFile); }
            else
            { log = File.AppendText(LogFile); }

            log.Write(DateTime.Now.ToString() + "  ");
            log.WriteLine(strLogText);
            //log.Close();
           log.Flush();
           log.Close();
        }
        #endregion
    }
}
