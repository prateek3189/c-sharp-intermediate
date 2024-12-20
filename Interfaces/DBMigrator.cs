namespace Interfaces
{
    public class DBMigrator
    {
        private readonly ILogger _logger;

        public DBMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now.ToString());

            // Some Operation

            _logger.LogInfo("Migration finished at " + DateTime.Now.ToString());
        }
    }
}
