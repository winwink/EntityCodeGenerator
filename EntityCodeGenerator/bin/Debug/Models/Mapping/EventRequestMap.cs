using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Models.Mapping
{
    public class EventRequestMap : EntityTypeConfiguration<EventRequest>
    {
        public EventRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestGuid);

            // Properties
            this.Property(t => t.RequestGuid)
                .IsRequired()
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

            this.Property(t => t.EventProvince)
                .HasMaxLength(200);

            this.Property(t => t.EventProvinceName)
                .HasMaxLength(200);

            this.Property(t => t.EventCity)
                .HasMaxLength(200);

            this.Property(t => t.EventCityName)
                .HasMaxLength(200);

            this.Property(t => t.EventCounty)
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

            this.Property(t => t.InitiatorGuaranteeContent)
                .HasMaxLength(500);

            this.Property(t => t.OwnerGuaranteeContent)
                .HasMaxLength(500);

            this.Property(t => t.BAApproverGuaranteeContent)
                .HasMaxLength(500);

            this.Property(t => t.CopyRequestType)
                .HasMaxLength(200);

            this.Property(t => t.CopyRequestNo)
                .HasMaxLength(200);

            this.Property(t => t.CopyRequestGuid)
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

            this.Property(t => t.AdditionalApproverID)
                .HasMaxLength(200);

            this.Property(t => t.AdditionalApproverName)
                .HasMaxLength(200);

            this.Property(t => t.CCID)
                .HasMaxLength(200);

            this.Property(t => t.CCName)
                .HasMaxLength(200);

            this.Property(t => t.FunctionName)
                .HasMaxLength(200);

            this.Property(t => t.FunctionCode)
                .HasMaxLength(200);

            this.Property(t => t.RegionName)
                .HasMaxLength(200);

            this.Property(t => t.RegionCode)
                .HasMaxLength(200);

            this.Property(t => t.BLSingleCode)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Event_Request");
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
            this.Property(t => t.InstitutionIsNoRisk).HasColumnName("InstitutionIsNoRisk");
            this.Property(t => t.EventRefID).HasColumnName("EventRefID");
            this.Property(t => t.EventRefName).HasColumnName("EventRefName");
            this.Property(t => t.EventName).HasColumnName("EventName");
            this.Property(t => t.EventStartDate).HasColumnName("EventStartDate");
            this.Property(t => t.EventEndDate).HasColumnName("EventEndDate");
            this.Property(t => t.EventLocation).HasColumnName("EventLocation");
            this.Property(t => t.EventLocationName).HasColumnName("EventLocationName");
            this.Property(t => t.EventProvince).HasColumnName("EventProvince");
            this.Property(t => t.EventProvinceName).HasColumnName("EventProvinceName");
            this.Property(t => t.EventCity).HasColumnName("EventCity");
            this.Property(t => t.EventCityName).HasColumnName("EventCityName");
            this.Property(t => t.EventCounty).HasColumnName("EventCounty");
            this.Property(t => t.EventCountyName).HasColumnName("EventCountyName");
            this.Property(t => t.EventOtherLocation).HasColumnName("EventOtherLocation");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.RequestUrl).HasColumnName("RequestUrl");
            this.Property(t => t.ProcInstID).HasColumnName("ProcInstID");
            this.Property(t => t.DiseaseArea).HasColumnName("DiseaseArea");
            this.Property(t => t.BudgetAmount).HasColumnName("BudgetAmount");
            this.Property(t => t.IsInitiatorGuarantee).HasColumnName("IsInitiatorGuarantee");
            this.Property(t => t.InitiatorGuaranteeContent).HasColumnName("InitiatorGuaranteeContent");
            this.Property(t => t.IsOwnerGuarantee).HasColumnName("IsOwnerGuarantee");
            this.Property(t => t.OwnerGuaranteeContent).HasColumnName("OwnerGuaranteeContent");
            this.Property(t => t.IsBAApproverGuarantee).HasColumnName("IsBAApproverGuarantee");
            this.Property(t => t.BAApproverGuaranteeContent).HasColumnName("BAApproverGuaranteeContent");
            this.Property(t => t.CopyRequestType).HasColumnName("CopyRequestType");
            this.Property(t => t.CopyRequestNo).HasColumnName("CopyRequestNo");
            this.Property(t => t.CopyRequestGuid).HasColumnName("CopyRequestGuid");
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
            this.Property(t => t.AdditionalApproverID).HasColumnName("AdditionalApproverID");
            this.Property(t => t.AdditionalApproverName).HasColumnName("AdditionalApproverName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.RatingNo).HasColumnName("RatingNo");
            this.Property(t => t.CanCallback).HasColumnName("CanCallback");
            this.Property(t => t.InstitutionIsNoRiskForOwner).HasColumnName("InstitutionIsNoRiskForOwner");
            this.Property(t => t.CCID).HasColumnName("CCID");
            this.Property(t => t.CCName).HasColumnName("CCName");
            this.Property(t => t.FunctionName).HasColumnName("FunctionName");
            this.Property(t => t.FunctionCode).HasColumnName("FunctionCode");
            this.Property(t => t.RegionName).HasColumnName("RegionName");
            this.Property(t => t.RegionCode).HasColumnName("RegionCode");
            this.Property(t => t.BLSingleCode).HasColumnName("BLSingleCode");
            this.Property(t => t.CompletedTime).HasColumnName("CompletedTime");
        }
    }
}
