using System.ComponentModel.DataAnnotations.Schema;
using CSWF.CommonService.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CSWF.CommonService.Entity.Mapping
{
    public class RequestCarFleetMap : EntityTypeConfiguration<RequestCarFleet>
    {
        public RequestCarFleetMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestID);

            // Properties
            this.Property(t => t.RequestID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RequestNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RequestTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RequestTypeName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InitiatorID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InitiatorName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RequestUrl)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreateBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FormFields)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.BACode)
                .HasMaxLength(200);

            this.Property(t => t.BAName)
                .HasMaxLength(200);

            this.Property(t => t.BLCode)
                .HasMaxLength(200);

            this.Property(t => t.BLName)
                .HasMaxLength(200);

            this.Property(t => t.FunctionRegionCode)
                .HasMaxLength(200);

            this.Property(t => t.FunctionRegionName)
                .HasMaxLength(200);

            this.Property(t => t.DriverLicenseCode)
                .HasMaxLength(200);

            this.Property(t => t.DriverLicenseType)
                .HasMaxLength(200);

            this.Property(t => t.VehicleLicenseCode)
                .HasMaxLength(200);

            this.Property(t => t.RentingTypeCode)
                .HasMaxLength(200);

            this.Property(t => t.RentingTypeName)
                .HasMaxLength(200);

            this.Property(t => t.DriverName)
                .HasMaxLength(200);

            this.Property(t => t.RentingCompany)
                .HasMaxLength(200);

            this.Property(t => t.ActualUser)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Request_CarFleet");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.RequestNo).HasColumnName("RequestNo");
            this.Property(t => t.RequestTypeCode).HasColumnName("RequestTypeCode");
            this.Property(t => t.RequestTypeName).HasColumnName("RequestTypeName");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ProcInstID).HasColumnName("ProcInstID");
            this.Property(t => t.InitiatorID).HasColumnName("InitiatorID");
            this.Property(t => t.InitiatorName).HasColumnName("InitiatorName");
            this.Property(t => t.RequestUrl).HasColumnName("RequestUrl");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CompleteTime).HasColumnName("CompleteTime");
            this.Property(t => t.FormFields).HasColumnName("FormFields");
            this.Property(t => t.BACode).HasColumnName("BACode");
            this.Property(t => t.BAName).HasColumnName("BAName");
            this.Property(t => t.BLCode).HasColumnName("BLCode");
            this.Property(t => t.BLName).HasColumnName("BLName");
            this.Property(t => t.FunctionRegionCode).HasColumnName("FunctionRegionCode");
            this.Property(t => t.FunctionRegionName).HasColumnName("FunctionRegionName");
            this.Property(t => t.DriverLicenseCode).HasColumnName("DriverLicenseCode");
            this.Property(t => t.DriverLicenseType).HasColumnName("DriverLicenseType");
            this.Property(t => t.DriverLicenseStartDate).HasColumnName("DriverLicenseStartDate");
            this.Property(t => t.DriverLicenseEndDate).HasColumnName("DriverLicenseEndDate");
            this.Property(t => t.VehicleLicenseCode).HasColumnName("VehicleLicenseCode");
            this.Property(t => t.CompulsoryInsuranceStartDate).HasColumnName("CompulsoryInsuranceStartDate");
            this.Property(t => t.CompulsoryInsuranceEndDate).HasColumnName("CompulsoryInsuranceEndDate");
            this.Property(t => t.YearlyInspectionDate).HasColumnName("YearlyInspectionDate");
            this.Property(t => t.RentingTypeCode).HasColumnName("RentingTypeCode");
            this.Property(t => t.RentingTypeName).HasColumnName("RentingTypeName");
            this.Property(t => t.HasDriver).HasColumnName("HasDriver");
            this.Property(t => t.DriverName).HasColumnName("DriverName");
            this.Property(t => t.RentingCompany).HasColumnName("RentingCompany");
            this.Property(t => t.ActualUser).HasColumnName("ActualUser");
        }
    }
}
