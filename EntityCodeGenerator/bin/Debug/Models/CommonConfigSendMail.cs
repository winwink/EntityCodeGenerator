using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Models
{
    public partial class CommonConfigSendMail
    {
        public int ConfigID { get; set; }
        public string Module { get; set; }
        public string RequestType { get; set; }
        public string ActivityName { get; set; }
        public Nullable<bool> IsSendMail { get; set; }
    }
}
