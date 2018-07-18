using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Entity
{
    public  class CommonAttachmentsConfig
    {
        public string AttachmentConfigGuid { get; set; }
        public string RequestType { get; set; }
        public string RequestSubType { get; set; }
        public string AttachmentType { get; set; }
        public string AttachmentTypeName { get; set; }
        public Nullable<bool> IsMandatory { get; set; }
        public Nullable<bool> IsAddWatermark { get; set; }
        public string Condition { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
