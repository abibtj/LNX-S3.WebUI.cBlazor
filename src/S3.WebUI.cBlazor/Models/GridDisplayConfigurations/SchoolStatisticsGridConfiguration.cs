
using Blazor.FlexGrid.Components.Configuration;
using Blazor.FlexGrid.Components.Configuration.Builders;

namespace S3.WebUI.cBlazor.Models.GridDisplayConfigurations
{
    public class SchoolStatisticsGridConfiguration : IEntityTypeConfiguration<SchoolStatistics>
    {
        public void Configure(EntityTypeBuilder<SchoolStatistics> builder)
        {
            //builder.HasEmptyItemsMessage("<h1>Test</h1>");

            builder.Property(x => x.Name).HasOrder(1).HasCaption("School Name").IsSortable().IsFilterable();

            builder.Property(x => x.Category).HasOrder(2).IsSortable().IsFilterable();

            builder.Property(x => x.Location).HasOrder(3).IsSortable().IsFilterable();

            builder.Property(x => x.NumberOfClasses).HasOrder(4).HasCaption("Classes").IsSortable();

            builder.Property(x => x.NumberOfStudents).HasOrder(5).HasCaption("Students").IsSortable();

            builder.Property(x => x.NumberOfTeachers).HasOrder(6).HasCaption("Teachers").IsSortable();

            builder.Property(x => x.Administrator).HasOrder(7);

            builder.Property(x => x.PhoneNumber).HasOrder(8).HasCaption("Phone");

            //builder.Property(x => x.Id).IsVisible(false);

            builder.Property(x => x.AdministratorId).IsVisible(false);

            builder.Property(x => x.CreatedDate).IsVisible(false);

            builder.Property(x => x.UpdatedDate).IsVisible(false);

            builder.Property(x => x.Email).IsVisible(false);
        }
    }
}