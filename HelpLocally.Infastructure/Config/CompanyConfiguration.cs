using HelpLocally.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpLocally.Infastructure.Config
{
    public class CompanyConfiguration :IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Companies");
            
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Nip).IsRequired();
            builder.Property(x => x.BankAccountNumber).IsRequired();

            builder.HasIndex(x => x.Name);
        }
    }
}