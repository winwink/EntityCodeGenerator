using System;
using System.Collections.Generic;

namespace Common.CSWF.Entity
{
    public  class CommonAttachmentsConfig
    {
        public int ID { get; set; }
        public string ProcessCode { get; set; }
        public string RequestType { get; set; }
        public string RequestSubType { get; set; }
        public string AttachmentType { get; set; }
        public string AttachmentTypeName { get; set; }
        public Nullable<bool> IsMandatory { get; set; }
        public Nullable<bool> IsAddWatermark { get; set; }
        public string Condition { get; set; }
        public int OrderId { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
