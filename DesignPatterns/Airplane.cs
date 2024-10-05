namespace DesignPatterns
{
    public class Airplane : IMedium
    {
        public void Deliver(string good)
        {
            Console.WriteLine($"Airplane: Deliver Good - {good}");
        }
    }
}
