using System.Collections.Generic;
namespace EntertainMe.Models;

public class Customer 
{
    public int Id {get;set;}
    public User? UserId { get; set; }
}