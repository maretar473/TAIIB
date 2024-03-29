using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MT_TAIIB_WebApi.Model
{
  public class OrderPosition
  {
    [Key]
    public int Id { get; set; }
    public int Order_Id { get; set; }
    [ForeignKey(nameof(Order_Id))]
    public Order Order { get; set; }
    public int Amount { get; set; }
    [Precision(10,2)]
    public decimal Price { get; set; }
    public int Product_Id { get; set; }
    [ForeignKey(nameof(Product_Id))]
    public Product Product { get; set; }
        public void Configure(EntityTypeBuilder<OrderPosition> builder)
        {
            builder.HasOne(x => x.Order)
                    .WithMany(x => x.OrderPositions)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.OrderPosition)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
