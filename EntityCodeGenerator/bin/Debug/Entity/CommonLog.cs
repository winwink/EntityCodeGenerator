using System;
using System.Collections.Generic;

namespace Common.CSWF.Entity
{
    public  class CommonLog
    {
        public int ID { get; set; }
        public long ReqeustID { get; set; }
        public string Source { get; set; }
        public string LogLevel { get; set; }
        public string Message { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
