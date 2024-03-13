using Microsoft.EntityFrameworkCore;
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
    public IEnumerable<OrderPosition> Positions { get; set; }
    
  }
}
