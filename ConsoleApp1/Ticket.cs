using System;

public class Ticket
{
    private static int counter = 0;
    public int TicketId { get; }  
    private decimal price;

    public string MovieName { get; set; }

    public decimal Price
    {
        get => price;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Price must be greater than 0");
            price = value;
        }
    }

    public Ticket(string movieName, decimal price)
    {
        MovieName = movieName;
        Price = price;
        counter++;
        TicketId = counter;
    }

   
    public decimal PriceAfterTax => Price * 1.14m;

    public override string ToString()
    {
        return $"Ticket ID: {TicketId}, Movie: {MovieName}, Price: {Price:C}, PriceAfterTax: {PriceAfterTax:C}";
    }

    public static int GetTotalTickets()
    {
        return counter;
    }
}