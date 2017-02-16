using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace rooms_api_netcore.Models {
  public class Room {
    [Key]
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    public string Key { get; set; }
    public string Name { get; set; }
    public List<Reservation> Reservations { get; set;}
  }
}