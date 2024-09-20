using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Net.Http.Headers;

namespace Taxi.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    
    public int Userid {get;set;}
   [Required]
  public string Name {get;set;}
  [Required]
 public string Surname {get;set;}
 [Required]
  public string Id_number {get;set;}
  [Required]
 public string  Cellphone {get;set;}
 [Required]
 public string Email {get;set;}
 [Required]
  public string Username {get;set;}
  [Required]
  public string Password {get;set;}
  public DateTime CreatedAt {get;set;}

  public UserType UserType {get;set;}
public int Owner_id {get;set;}
  public decimal Latitude  {get;set;}
  public decimal Longitude {get;set;}
}
public enum UserType{
    driver,
    owner,
    manager
}