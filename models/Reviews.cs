public class Reviews

{
    public int Id {get;set;}
    public string? Description {get;set;}
    public Venue? VenueId { get; set; }
    public Artist? ArtistId{ get; set; }
    public bool BookAgain {get;set;}
}