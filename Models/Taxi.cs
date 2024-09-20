using System.Buffers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taxi.Models;

public class Taxi
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TaxiId {get;set;}
    public string NumberPlate {get;set;}
    public int OwnerId {get;set;}
    public virtual User Owner {get;set;}
    public int DriverId {get;set;}
    public virtual User Driver {get;set;}
    public Status Status {get;set;}

    public int RouteId {get;set;}
    public virtual Route Route {get;set;}

    
}
public enum Status{
    available,
    unavailable,
    inservice
}