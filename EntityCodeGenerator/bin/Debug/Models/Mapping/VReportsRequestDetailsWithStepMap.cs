using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Models.Mapping
{
    public class VReportsRequestDetailsWithStepMap : EntityTypeConfiguration<VReportsRequestDetailsWithStep>
    {
        public VReportsRequestDetailsWithStepMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestType);

            // Properties
            this.Property(t => t.RequestType)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.RequestGuid)
                .HasMaxLength(200);

            this.Property(t => t.RequestNo)
                .HasMaxLength(200);

            this.Property(t => t.InitiatorID)
                .HasMaxLength(200);

            this.Property(t => t.InitiatorName)
                .HasMaxLength(200);

            this.Property(t => t.InitiatorPhoneNo)
                .HasMaxLength(200);

            this.Property(t => t.OwnerID)
                .HasMaxLength(200);

            this.Property(t => t.OwnerName)
                .HasMaxLength(200);

            this.Property(t => t.OwnerPhoneNo)
                .HasMaxLength(200);

            this.Property(t => t.BAName)
                .HasMaxLength(200);

            this.Property(t => t.BACode)
                .HasMaxLength(200);

            this.Property(t => t.BLName)
                .HasMaxLength(200);

            this.Property(t => t.BLCode)
                .HasMaxLength(200);

            this.Property(t => t.FunctionRegionName)
                .HasMaxLength(200);

            this.Property(t => t.FunctionRegionCode)
                .HasMaxLength(50);

            this.Property(t => t.RequestTypeName)
                .HasMaxLength(200);

            this.Property(t => t.RequestTypeCode)
                .HasMaxLength(200);

            this.Property(t => t.RequestSubTypeName)
                .HasMaxLength(200);

            this.Property(t => t.RequestSubTypeCode)
                .HasMaxLength(200);

            this.Property(t => t.InstitutionCode)
                .HasMaxLength(50);

            this.Property(t => t.InstitutionName)
                .HasMaxLength(200);

            this.Property(t => t.EventRefID)
                .HasMaxLength(200);

            this.Property(t => t.EventRefName)
                .HasMaxLength(200);

            this.Property(t => t.EventName)
                .HasMaxLength(200);

            this.Property(t => t.EventLocation)
                .HasMaxLength(200);

            this.Property(t => t.EventLocationName)
                .HasMaxLength(200);

            this.Property(t => t.EventProvinceName)
                .HasMaxLength(200);

            this.Property(t => t.EventCityName)
                .HasMaxLength(200);

            this.Property(t => t.EventCountyName)
                .HasMaxLength(200);

            this.Property(t => t.EventOtherLocation)
                .HasMaxLength(500);

            this.Property(t => t.State)
                .HasMaxLength(50);

            this.Property(t => t.RequestUrl)
                .HasMaxLength(500);

            this.Property(t => t.DiseaseArea)
                .HasMaxLength(200);

            this.Property(t => t.ReqeustVenue)
                .HasMaxLength(500);

            this.Property(t => t.RequestDescription)
                .HasMaxLength(4000);

            this.Property(t => t.RequestMainDescription)
                .HasMaxLength(500);

            this.Property(t => t.RequestPurpose)
                .HasMaxLength(500);

            this.Property(t => t.RequestPurposeRemark)
                .HasMaxLength(4000);

            this.Property(t => t.CCID)
                .HasMaxLength(200);

            this.Property(t => t.CCName)
                .HasMaxLength(200);

            this.Property(t => t.IsSameContent)
                .HasMaxLength(200);

            this.Property(t => t.IsStandardContract)
                .HasMaxLength(200);

            this.Property(t => t.IsStandardCompliance)
                .HasMaxLength(200);

            this.Property(t => t.IsBigChange)
                .HasMaxLength(200);

            this.Property(t => t.IsInvoiceAfterDays)
                .HasMaxLength(200);

            this.Property(t => t.PONo)
                .HasMaxLength(200);

            this.Property(t => t.ActivityName)
                .HasMaxLength(50);

            this.Property(t => t.Approver)
                .HasMaxLength(50);

            this.Property(t => t.Action)
                .HasMaxLength(50);

            this.Property(t => t.ActionTo)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(1000);

            this.Property(t => t.ApproverName)
                .HasMaxLength(50);

            this.Property(t => t.ActionToName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("V_Reports_RequestDetailsWithStep");
            this.Property(t => t.RequestType).HasColumnName("RequestType");
            this.Property(t => t.RequestGuid).HasColumnName("RequestGuid");
            this.Property(t => t.RequestNo).HasColumnName("RequestNo");
            this.Property(t => t.FormFields).HasColumnName("FormFields");
            this.Property(t => t.RequestDate).HasColumnName("RequestDate");
            this.Property(t => t.InitiatorID).HasColumnName("InitiatorID");
            this.Property(t => t.InitiatorName).HasColumnName("InitiatorName");
            this.Property(t => t.InitiatorPhoneNo).HasColumnName("InitiatorPhoneNo");
            this.Property(t => t.OwnerID).HasColumnName("OwnerID");
            this.Property(t => t.OwnerName).HasColumnName("OwnerName");
            this.Property(t => t.OwnerPhoneNo).HasColumnName("OwnerPhoneNo");
            this.Property(t => t.BAName).HasColumnName("BAName");
            this.Property(t => t.BACode).HasColumnName("BACode");
            this.Property(t => t.BLName).HasColumnName("BLName");
            this.Property(t => t.BLCode).HasColumnName("BLCode");
            this.Property(t => t.FunctionRegionName).HasColumnName("FunctionRegionName");
            this.Property(t => t.FunctionRegionCode).HasColumnName("FunctionRegionCode");
            this.Property(t => t.RequestTypeName).HasColumnName("RequestTypeName");
            this.Property(t => t.RequestTypeCode).HasColumnName("RequestTypeCode");
            this.Property(t => t.RequestSubTypeName).HasColumnName("RequestSubTypeName");
            this.Property(t => t.RequestSubTypeCode).HasColumnName("RequestSubTypeCode");
            this.Property(t => t.InstitutionCode).HasColumnName("InstitutionCode");
            this.Property(t => t.InstitutionName).HasColumnName("InstitutionName");
            this.Property(t => t.EventRefID).HasColumnName("EventRefID");
            this.Property(t => t.EventRefName).HasColumnName("EventRefName");
            this.Property(t => t.EventName).HasColumnName("EventName");
            this.Property(t => t.EventStartDate).HasColumnName("EventStartDate");
            this.Property(t => t.EventEndDate).HasColumnName("EventEndDate");
            this.Property(t => t.EventLocation).HasColumnName("EventLocation");
            this.Property(t => t.EventLocationName).HasColumnName("EventLocationName");
            this.Property(t => t.EventProvinceName).HasColumnName("EventProvinceName");
            this.Property(t => t.EventCityName).HasColumnName("EventCityName");
            this.Property(t => t.EventCountyName).HasColumnName("EventCountyName");
            this.Property(t => t.EventOtherLocation).HasColumnName("EventOtherLocation");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.RequestUrl).HasColumnName("RequestUrl");
            this.Property(t => t.ProcInstID).HasColumnName("ProcInstID");
            this.Property(t => t.DiseaseArea).HasColumnName("DiseaseArea");
            this.Property(t => t.BudgetAmount).HasColumnName("BudgetAmount");
            this.Property(t => t.ReqeustVenue).HasColumnName("ReqeustVenue");
            this.Property(t => t.RequestDescription).HasColumnName("RequestDescription");
            this.Property(t => t.RequestMainDescription).HasColumnName("RequestMainDescription");
            this.Property(t => t.RequestPurpose).HasColumnName("RequestPurpose");
            this.Property(t => t.RequestPurposeRemark).HasColumnName("RequestPurposeRemark");
            this.Property(t => t.RequestHCPNo).HasColumnName("RequestHCPNo");
            this.Property(t => t.RequestRocheNo).HasColumnName("RequestRocheNo");
            this.Property(t => t.RequestOtherNo).HasColumnName("RequestOtherNo");
            this.Property(t => t.RequestTotalNo).HasColumnName("RequestTotalNo");
            this.Property(t => t.RequestMainTotalNo).HasColumnName("RequestMainTotalNo");
            this.Property(t => t.RequestSupportNo).HasColumnName("RequestSupportNo");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.RatingNo).HasColumnName("RatingNo");
            this.Property(t => t.CCID).HasColumnName("CCID");
            this.Property(t => t.CCName).HasColumnName("CCName");
            this.Property(t => t.ContractProcInstID).HasColumnName("ContractProcInstID");
            this.Property(t => t.IsSameContent).HasColumnName("IsSameContent");
            this.Property(t => t.IsStandardContract).HasColumnName("IsStandardContract");
            this.Property(t => t.IsStandardCompliance).HasColumnName("IsStandardCompliance");
            this.Property(t => t.IsBigChange).HasColumnName("IsBigChange");
            this.Property(t => t.IsInvoiceAfterDays).HasColumnName("IsInvoiceAfterDays");
            this.Property(t => t.IsXR2R).HasColumnName("IsXR2R");
            this.Property(t => t.PONo).HasColumnName("PONo");
            this.Property(t => t.ActivityName).HasColumnName("ActivityName");
            this.Property(t => t.Approver).HasColumnName("Approver");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.ActionTo).HasColumnName("ActionTo");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.SubmitTime).HasColumnName("SubmitTime");
            this.Property(t => t.ApproverName).HasColumnName("ApproverName");
            this.Property(t => t.ActionToName).HasColumnName("ActionToName");
        }
    }
}
