using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Models
{
    public partial class CommonOrgBusinessLine
    {
        public string BLCode { get; set; }
        public string BACode { get; set; }
        public string BLNameCN { get; set; }
        public string BLNameEN { get; set; }
        public bool IsActive { get; set; }
        public int OrderId { get; set; }
    }
}
