namespace RollspelsValvet
{
    public interface ICurrency
    {
        void Add(int amount);
        void Subtract(int amount);
        string Format();
    }
}