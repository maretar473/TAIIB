using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MT_TAIIB_WebApi.Model
{
  public class Order
  {
    [Key]
    public int Id { get; set; }
    public int User_Id { get; set; }
    [ForeignKey(nameof(User_Id))]
    public User User { get; set; }
    public DateTime DateTime { get; set; }
    public IEnumerable<OrderPosition> OrderPositions { get; set; }
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasMany(x => x.OrderPositions)
                .WithOne(x => x.Order)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.User)
                .WithMany(x => x.Orders)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
