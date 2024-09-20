using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taxi.Models;

public class Trip
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TripId{get;set;}
    public int TaxiId {get;set;}
    public virtual Taxi Taxi {get;set;}
    public DateTime StartTime {get;set;}
    public DateTime EndTime {get;set;}
    public decimal Earnings {get;set;}
    public decimal  ProcessingFee {get;set;}

    
}