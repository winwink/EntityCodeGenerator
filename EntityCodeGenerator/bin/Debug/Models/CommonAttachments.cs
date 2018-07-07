using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Models
{
    public partial class CommonAttachments
    {
        public int AttachmentID { get; set; }
        public string RequestGuid { get; set; }
        public string AttachmentType { get; set; }
        public string AttachmentTypeName { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public Nullable<bool> IsAddWatermark { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public string LastUpdateBy { get; set; }
        public Nullable<System.DateTime> LastUpdateTime { get; set; }
    }
}
