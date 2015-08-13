using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WS_Logs.Logic;

namespace WS_Logs.UnitTest
{
    [TestClass]
    public class WSTraceUnitTest
    {
        private string AppName;
        //private TraceLevel tracelLevel;
        private string message;
        private string userID;
        
        [TestInitialize]
        public void initialize()
        { 
        
        }

        [TestMethod]
        public void WriteTraceUnitTest()
        {
            AppName = "UnitTest";
           TraceLevel tracelLevel = TraceLevel.Information;
            message = "Test Message";
            userID = "TestUser";
            WSTrace.writeTrace(AppName, 0, message, userID);

        }
    }
}
