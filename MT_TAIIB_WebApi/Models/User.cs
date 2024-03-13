using System.ComponentModel.DataAnnotations;

namespace MT_TAIIB_WebApi.Model
{
  public class User
  {
    public enum UserGroup
    {
      Admin,
      Casual
    }
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string Login { get; set; }
    [MaxLength(100)]
    public string Password { get; set; }
    public UserGroup Typ { get; set; }
    public bool IsActibe { get; set; }
    public IEnumerable<Order> Orders { get; set; }
    public IEnumerable<BasketPosition> BasketPositions { get; set; }
  }
}
