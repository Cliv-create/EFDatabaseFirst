namespace EFDatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (System.IO.File.Exists("config.json"))
                {
                    ConfigManager.LoadConfig();
                }
                else
                {
                    ConfigManager.GenerateInitialConfig();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Hello, World!");
        }
    }
}
