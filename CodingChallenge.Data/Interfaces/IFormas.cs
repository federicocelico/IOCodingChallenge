namespace CodingChallenge.Data.Interfaces
{
    public interface IFormas
    {
        decimal _lado { get; set; }
        int _cantidad { get; set; }
        string _nombre { get; set; }
        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}