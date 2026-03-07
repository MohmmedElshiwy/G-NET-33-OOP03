public class Projector
{
    public void Start() => Console.WriteLine("Projector is ON");
    public void Stop() => Console.WriteLine("Projector is OFF");
}

public class Cinema
{
    public string CinemaName { get; set; }
    private Projector projector = new Projector();
    private Ticket[] tickets = new Ticket[20];

    public Cinema(string name)
    {
        CinemaName = name;
    }

    public void AddTicket(Ticket t)
    {
        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i] == null)
            {
                tickets[i] = t;
                return;
            }
        }
        Console.WriteLine("Cinema is full! Cannot add more tickets.");
    }

    public void PrintAllTickets()
    {
        Console.WriteLine($"All Tickets in {CinemaName}:");
        foreach (var t in tickets)
        {
            if (t != null)
                Console.WriteLine(t);
        }
    }

    public void OpenCinema()
    {
        Console.WriteLine($"Cinema {CinemaName} is now OPEN");
        projector.Start();
    }

    public void CloseCinema()
    {
        Console.WriteLine($"Cinema {CinemaName} is now CLOSED");
        projector.Stop();
    }
}