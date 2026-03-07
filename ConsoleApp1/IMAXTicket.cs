public sealed class IMAXTicket : Ticket 
{
    public bool Is3D { get; set; }

    public IMAXTicket(string movieName, decimal price, bool is3D)
        : base(movieName, price + (is3D ? 30 : 0)) 
    {
        Is3D = is3D;
    }

    public override string ToString()
    {
        return base.ToString() + $", IMAX 3D: {Is3D}";
    }
}