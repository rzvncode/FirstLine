namespace FirstLine.Interfaces
{
    public interface IDiscount
    {
        string SKU { get; set; }
        int Quantity { get; set; }

        double Value { get; set; }
    }
}
