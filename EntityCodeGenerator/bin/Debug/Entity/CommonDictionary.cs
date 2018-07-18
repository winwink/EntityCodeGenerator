using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Entity
{
    public  class CommonDictionary
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string SubSubType { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> OrderId { get; set; }
    }
}
