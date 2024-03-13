using Microsoft.EntityFrameworkCore;
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
  }
}
