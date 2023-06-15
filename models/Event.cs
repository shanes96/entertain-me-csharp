using System.Collections.Generic;
namespace EntertainMe.Models;

public class Event 
{
    public int Id {get;set;}
    public string? Description {get;set;}
    public int VenueId { get; set; }
    public Artist? ArtistId { get; set; }
    public int TicketPrice {get;set;}
    public DateTime EventTime {get;set;}
    public User? UserId { get; set; }
}