using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taxi.Models;

public class Route 
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RouteId{get;set;}
    public string StartDestination {get;set;}
    public string EndDestination {get;set;}
    public decimal Fare {get;set;}
    public DateTime CreatedAt {get;set;}
}