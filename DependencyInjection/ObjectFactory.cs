using System;
using System.Collections.Generic;
using System.Text;
using DependencyInjection.Abstract;
using DependencyInjection.DataAccess;

namespace DependencyInjection
{
    class ObjectFactory
    {
        public static IDataAccessLayer GetMicrosoftServerObject() => new MicrosoftServer();

        public static IDataAccessLayer GetLinuxServerObject() => new LinuxServer();
    }
}
