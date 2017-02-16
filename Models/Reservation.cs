using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace rooms_api_netcore.Models
{
  public class Reservation
  {
    [Key]
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    public string Key { get; set; }
    public string Name { get; set; }
    public string Owner { get; set; }
    public string OwnerEmail { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
  }
}