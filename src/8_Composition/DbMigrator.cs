using System;

// So compostion and inheritance is all about code reusability however, inheritance make applicatns tightly coupled while compostion is loosely coupled, so the one to use is entirely up to you.
namespace _8_Composition
{
    public class DbMigrator
    {
        private readonly Logger _logger;
        public Installer Installer { get; set; }

        public DbMigrator(Logger logger)    
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating now...");
            Installer.Install();
        }
    }
}