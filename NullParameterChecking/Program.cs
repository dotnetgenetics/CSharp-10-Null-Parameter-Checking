namespace NullParameterChecking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? email = null;
            CheckEmail(email);
        }

        static void CheckEmail(string email)
        {
            ArgumentNullException.ThrowIfNull(email);
            Console.WriteLine(email);
        }
    }
}
