using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace TemplatePattern.AbstractTemplates
{
    abstract class DatabaseManager
    {
        public void SaveToDatabase()
        {
            //operations ...
            //error checking ...
            //connectionstring control ...
            //recheck all configurations ...
            this.Save();
        }
        protected abstract void Save();
    }
}
