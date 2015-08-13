using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS_Logs.Logic
{
    public enum TraceLevel
    {
        Error=0,
        Warning =1,
        Information=2,
        Detail=3
    }

    public enum TraceType
    { 
        File=1,
        DB=2,
        Both=3
    }
}
