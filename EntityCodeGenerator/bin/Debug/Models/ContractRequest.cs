using System;
using System.Collections.Generic;

namespace RDCN.CPT.Data.Models
{
    public partial class ContractRequest
    {
        public string ContractGuid { get; set; }
        public string ContractNo { get; set; }
        public string RequestGuid { get; set; }
        public string RequestNo { get; set; }
        public string RequestUrl { get; set; }
        public string IsSameContent { get; set; }
        public string IsSameContentText { get; set; }
        public string IsStandardContract { get; set; }
        public string IsStandardContractText { get; set; }
        public string IsStandardCompliance { get; set; }
        public string IsStandardComplianceText { get; set; }
        public string IsBigChange { get; set; }
        public string IsBigChangeText { get; set; }
        public string IsInvoiceAfterDays { get; set; }
        public string IsInvoiceAfterDaysText { get; set; }
        public string ContractUrl { get; set; }
        public string State { get; set; }
        public Nullable<int> ProcInstID { get; set; }
        public string InitiatorID { get; set; }
        public string InitiatorName { get; set; }
        public string OwnerID { get; set; }
        public string OwnerName { get; set; }
        public string FormFields { get; set; }
        public string RequestFormFields { get; set; }
        public Nullable<System.DateTime> ContractRequestDate { get; set; }
        public Nullable<bool> IsXR2R { get; set; }
        public string PONo { get; set; }
    }
}
