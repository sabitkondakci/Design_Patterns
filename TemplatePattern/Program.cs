using System;
using TemplatePattern.AbstractTemplates;
using TemplatePattern.SolidComponents;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager dbSQLManager = new SQLDatabase();
            DatabaseManager dbOracleManager = new OracleDatabase();

            dbSQLManager.SaveToDatabase();
            dbOracleManager.SaveToDatabase();
            
        }
    }
}
