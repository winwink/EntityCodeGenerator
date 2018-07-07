using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Models
{
    public partial class CommonExportFiles
    {
        public int ID { get; set; }
        public string File { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    }
}
