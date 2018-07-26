using System;
using System.Collections.Generic;

namespace Common.CSWF.Entity
{
    public  class CommonAttachments
    {
        public int ID { get; set; }
        public long RequestID { get; set; }
        public string AttachmentType { get; set; }
        public string AttachmentTypeName { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public Nullable<bool> IsAddWatermark { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
    }
}
