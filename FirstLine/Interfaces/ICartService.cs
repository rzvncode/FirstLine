namespace FirstLine.Interfaces
{
    public interface ICartService
    {
        void Add(Product item);
        void Remove(Product item);
        double GetTotal();
    }
}
