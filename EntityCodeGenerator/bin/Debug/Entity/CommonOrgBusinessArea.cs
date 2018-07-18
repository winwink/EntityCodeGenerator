using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Entity
{
    public  class CommonOrgBusinessArea
    {
        public string BACode { get; set; }
        public string BANameCN { get; set; }
        public string BANameEN { get; set; }
        public bool IsActive { get; set; }
        public int OrderId { get; set; }
    }
}
