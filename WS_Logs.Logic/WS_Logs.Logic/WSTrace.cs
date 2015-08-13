using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WS_Logs.Logic
{
    public class WSTrace
    {
        private static WS_LogsEntities DBLogs = new WS_LogsEntities();
        public static string WS_LogsFilePath = string.Empty;
        public static string traceFileName = string.Empty;
        public static string auditFileName = string.Empty;
        public static TraceType traceType;
        
        static WSTrace()
        {
            WS_LogsFilePath = @"C:\WS_Trace\";
            traceFileName = "Trace.txt";
            auditFileName = "Audit.txt";
            traceType = TraceType.Both;
        }
        public static void writeTrace(string appName, TraceLevel traceLevel, string message, string userID)
        {
            if (traceType == TraceType.DB || traceType == TraceType.Both)
            {
                Trace trace = new Trace();
                trace.AppName = appName;
                trace.Message = message;
                trace.TraceType = 0;
                trace.TraceLevel = (short)traceLevel;
                trace.UserID = userID;
                trace.CreateDateTime = DateTime.Now;

                DBLogs.Traces.Add(trace);
                DBLogs.SaveChanges();
            }
            if (traceType == TraceType.File || traceType == TraceType.Both)
            {
                string msg = string.Empty;
                msg = DateTime.Now.ToLongDateString() + " : " + appName + " : " + traceLevel.ToString() + " : " +
                    message + " : " + userID;
                writeFile(msg, WS_LogsFilePath + "\\" + traceFileName);
            }
        }

        public static void writeAudit(string appName, TraceLevel traceLevel, string message, string userID)
        {
            if (traceType == TraceType.DB || traceType == TraceType.Both)
            {
                Trace trace = new Trace();
                trace.AppName = appName;
                trace.Message = message;
                trace.TraceType = (short)traceLevel;
                trace.TraceLevel = (short)traceLevel;
                trace.UserID = userID;
                trace.CreateDateTime = DateTime.Now;

                DBLogs.Traces.Add(trace);
                DBLogs.SaveChanges();
            }
            if (traceType == TraceType.File || traceType == TraceType.Both)
            {
                string msg = string.Empty;
                msg = DateTime.Now.ToLongDateString() + " : " + appName + " : " + traceLevel.ToString() + " : " +
                    message + " : " + userID;
                writeFile(msg,WS_LogsFilePath + "\\" + traceFileName);
            }
        }

        public static void writeAudit(string appName, Exception ex, string userID)
        {
            if (traceType == TraceType.DB || traceType == TraceType.Both)
            {
                Trace trace = new Trace();
                trace.AppName = appName;
                trace.Message = ex.Message;
                trace.TraceType = 1;
                trace.TraceLevel = (short)TraceLevel.Error;
                trace.UserID = userID;
                trace.CreateDateTime = DateTime.Now;

                DBLogs.Traces.Add(trace);
                DBLogs.SaveChanges();
            }
            if (traceType == TraceType.File || traceType == TraceType.Both)
            {
                string msg = string.Empty;
                msg = DateTime.Now.ToLongDateString() + " : " + appName + " : " + TraceLevel.Error.ToString() + " : " +
                    ex.Message + " : " + userID;
                writeFile(msg, WS_LogsFilePath + "\\" + auditFileName);
            }
        }

        public static void writeFile(string Msg,string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine(Msg);
            sw.Close();
            file.Close();
        }

    }
}
