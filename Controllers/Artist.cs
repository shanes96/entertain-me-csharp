using EntertainMe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EntertainMe.Controllers
{
    [ApiController]
    [Route("api/artists")]
    public class ArtistsController : ControllerBase
    {
        private readonly List<Artist> _artists;

        public ArtistsController()
        {
            // Initialize a list of artists (dummy data)
            _artists = new List<Artist>
            {
                new Artist { Id = 1, UserId = new User { Id = 1, Name = "John Doe", IsArtist = false, PhoneNumber = 123456789 }, SpotifyLink = "https://spotify.com/artist1", ProfilePageImage = "profile1.jpg", ArtistPagePicture = "artist1.jpg" },
                new Artist { Id = 2, UserId = new User { Id = 2, Name = "Jane Smith", IsArtist = true, PhoneNumber = 987654321 }, SpotifyLink = "https://spotify.com/artist2", ProfilePageImage = "profile2.jpg", ArtistPagePicture = "artist2.jpg" }
            };
        }

        [HttpGet]
        public IActionResult GetAllArtists()
        {
            // Return the list of artists
            return Ok(_artists);
        }

        [HttpGet("{id}")]
        public IActionResult GetArtistById(int id)
        {
            // Find the artist with the given id
            var artist = _artists.Find(a => a.Id == id);

            if (artist == null)
            {
                return NotFound(); // Artist not found
            }

            // Return the artist
            return Ok(artist);
        }

        [HttpPost]
        public IActionResult CreateArtist(Artist artist)
        {
            // Generate a new unique id for the artist
            artist.Id = GetNewArtistId();

            // Add the artist to the list
            _artists.Add(artist);

            // Return the created artist
            return CreatedAtAction(nameof(GetArtistById), new { id = artist.Id }, artist);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateArtist(int id, Artist artist)
        {
            // Find the artist with the given id
            var existingArtist = _artists.Find(a => a.Id == id);

            if (existingArtist == null)
            {
                return NotFound(); // Artist not found
            }

            // Update the artist properties
            existingArtist.UserId = artist.UserId;
            existingArtist.SpotifyLink = artist.SpotifyLink;
            existingArtist.ProfilePageImage = artist.ProfilePageImage;
            existingArtist.ArtistPagePicture = artist.ArtistPagePicture;

            // Return the updated artist
            return Ok(existingArtist);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteArtist(int id)
        {
            // Find the artist with the given id
            var artist = _artists.Find(a => a.Id == id);

            if (artist == null)
            {
                return NotFound(); // Artist not found
            }

            // Remove the artist from the list
            _artists.Remove(artist);

            // Return success
            return NoContent();
        }

        // Helper method to generate a new unique artist id
        private int GetNewArtistId()
        {
            return _artists.Count + 1;
        }
    }
}
