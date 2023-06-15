using System.Security.Claims;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EntertainMe.Models;

namespace EnterTainMe.Controllers // Replace with your desired namespace
{
    [ApiController]
    [Route("api/users")] // Define the base route for all user-related endpoints

    public class UsersController : ControllerBase
    {
        // GET: api/users
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            // Logic to retrieve all users from the database or any other data source
            // Replace this with your own implementation
            var users = new List<User>
            {
                new User { Id = 1, Name = "John Doe", IsArtist = false, PhoneNumber = 123456789 },
                new User { Id = 2, Name = "Jane Smith", IsArtist = true, PhoneNumber = 987654321 }
            };

            return Ok(users); // Return the retrieved users as a response
        }

        // GET: api/users/{id}
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            // Logic to retrieve a user by its ID from the database or any other data source
            // Replace this with your own implementation
            var user = new User { Id = id, Name = "John Doe", IsArtist = false, PhoneNumber = 123456789 };

            if (user == null)
            {
                return NotFound(); // Return a 404 Not Found response if the user is not found
            }

            return Ok(user); // Return the retrieved user as a response
        }

        // POST: api/users
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            // Logic to create a new user in the database or any other data source
            // Replace this with your own implementation

            // Validate the user input and perform any necessary checks

            // Save the user to the database or any other data source

            // Return a 201 Created response with the created user
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        // PUT: api/users/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User user)
        {
            // Logic to update an existing user in the database or any other data source
            // Replace this with your own implementation

            // Validate the user input and perform any necessary checks

            // Update the user in the database or any other data source

            // Return a 200 OK response
            return Ok();
        }

        // DELETE: api/users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            // Logic to delete an existing user from the database or any other data source
            // Replace this with your own implementation

            // Perform the deletion

            // Return a 204 No Content response
            return NoContent();
        }
    }
}
