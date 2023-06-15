using System.Collections.Generic;
namespace EntertainMe.Models;

public class Artist 
{
    public int Id {get;set;}
    public User? UserId { get; set; }
    public string? SpotifyLink{get;set;}

    public string? ProfilePageImage {get;set;}
    public string? ArtistPagePicture {get;set;}
}