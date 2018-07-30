using System;
using System.Collections.Generic;

namespace Common.CSWF.Entity
{
    public  class CommonDictionary :IRecordEntity
    {
        public int ID { get; set; }
        public string ProcessCode { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string SubSubType { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public int OrderId { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}

