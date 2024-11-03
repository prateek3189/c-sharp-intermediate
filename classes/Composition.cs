namespace Constructors
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("We are installing app!!");
        }
    }

    public class DBMigrator
    {
        private readonly Logger _logger;

        public DBMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating DB!!!!");
        }
    }

    public class Logger
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
