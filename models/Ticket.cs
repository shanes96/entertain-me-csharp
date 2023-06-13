public class Ticket 

{
    public int Id {get;set;}
    public Event? EventId { get; set; }
    public User? UserId { get; set; }
    public int PurchaseTicketAmount {get;set;}
}