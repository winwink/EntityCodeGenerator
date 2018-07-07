using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Models
{
    public partial class CommonOrgFunctionRegion
    {
        public string FunctionRegionCode { get; set; }
        public string FunctionRegionNameCN { get; set; }
        public string FunctionRegionNameEN { get; set; }
        public string BLCode { get; set; }
        public bool IsActive { get; set; }
        public int OrderId { get; set; }
    }
}
