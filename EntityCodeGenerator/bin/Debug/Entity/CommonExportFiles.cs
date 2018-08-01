using System;
using System.Collections.Generic;

namespace CSWF.CommonService.Entity
{
    public  class CommonExportFiles :ICreateEntity
    {
        public int ID { get; set; }
        public string File { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}

