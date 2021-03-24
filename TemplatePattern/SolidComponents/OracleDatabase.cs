using System;
using System.Collections.Generic;
using System.Text;
using TemplatePattern.AbstractTemplates;

namespace TemplatePattern.SolidComponents
{
     class OracleDatabase:DatabaseManager
    {
        protected override void Save()
        {
            //operation ...
            Console.WriteLine("Saved to Oracle Database");
        }
    }
}
