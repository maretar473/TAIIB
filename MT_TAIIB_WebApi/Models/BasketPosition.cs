using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MT_TAIIB_WebApi.Model
{
  public class BasketPosition
  {
    [Key]
    public int Id { get; set; }
    public int User_Id { get; set; }
    [ForeignKey(nameof(User_Id))]
    public User User { get; set; }
    public int Product_Id { get; set; }
    [ForeignKey(nameof(User_Id))]
    public Product Product { get; set; }
    public int Amount { get; set; }
  }
}
