using System;
using System.Collections.Generic;

namespace Common.CSWF.Entity
{
    public  class CommonLog :ICreateEntity
    {
        public int ID { get; set; }
        public long ReqeustID { get; set; }
        public string Source { get; set; }
        public string LogLevel { get; set; }
        public string Message { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}

