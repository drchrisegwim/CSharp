using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Composition
{
    partial class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new Logger());
            Installer installer = new Installer(new Logger());

            dbMigrator.Migrate();
            installer.Install();

            Console.ReadLine();
        }
    }
}
