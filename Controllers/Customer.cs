using EntertainMe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EntertainMe.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        // GET: api/customers/{id}
        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            // Logic to retrieve a customer by its ID from the database or any other data source
            // Replace this with your own implementation
            var customer = new Customer { Id = id };

            if (customer == null)
            {
                return NotFound(); // Return a 404 Not Found response if the customer is not found
            }

            return Ok(customer); // Return the retrieved customer as a response
        }

        // POST: api/customers
        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            // Logic to create a new customer in the database or any other data source
            // Replace this with your own implementation

            // Validate the customer input and perform any necessary checks

            // Save the customer to the database or any other data source

            // Return a 201 Created response with the created customer
            return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer);
        }

        // PUT: api/customers/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, Customer customer)
        {
            // Logic to update an existing customer in the database or any other data source
            // Replace this with your own implementation

            // Validate the customer input and perform any necessary checks

            // Update the customer in the database or any other data source

            // Return a 200 OK response
            return Ok();
        }

        // DELETE: api/customers/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            // Logic to delete an existing customer from the database or any other data source
            // Replace this with your own implementation

            // Perform the deletion

            // Return a 204 No Content response
            return NoContent();
        }
    }
}
