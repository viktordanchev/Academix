using Academix.Infrastructure.Data.Models.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academix.Infrastructure.Data.Configurations
{
    public class RequestReceiverConfiguration : IEntityTypeConfiguration<RequestReceiver>
    {
        public void Configure(EntityTypeBuilder<RequestReceiver> builder)
        {
            builder
                .HasKey(rr => new { rr.RequestId, rr.ReceiverId });

            builder
                .HasOne(rr => rr.Request)
                .WithMany(r => r.RequestReceivers)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(rr => rr.Receiver) 
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
