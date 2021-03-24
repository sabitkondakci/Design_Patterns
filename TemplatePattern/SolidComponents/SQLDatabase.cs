using System;
using System.Collections.Generic;
using System.Text;
using TemplatePattern.AbstractTemplates;

namespace TemplatePattern.SolidComponents
{
    class SQLDatabase:DatabaseManager
    {
        protected override void Save()
        {
            //operations ...
            Console.WriteLine("Saved to Microsoft SQL Database");
        }
    }
}
