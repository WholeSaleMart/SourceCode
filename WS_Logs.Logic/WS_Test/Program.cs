using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_Logs.Logic;

namespace WS_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string AppName = "UnitTest";
            //TraceLevel tracelLevel = TraceLevel.Information;
            string message = "Test Message";
            string userID = "TestUser";
            WSTrace.writeTrace(AppName, 0, message, userID);
        }
    }
}
