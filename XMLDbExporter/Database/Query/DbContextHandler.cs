using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XMLDbExporter.Core;

namespace XMLDbExporter.Representation
{
    public class DbContextHandler : IDbContextHandler
    {
        public XMLDbExporter.DbContextHandlerConfiguration Configuration
        {
            get;
            set;
        }

        public void Import(DataTransferObject o, string dbName)
        {
            throw new System.NotImplementedException();
        }

        public DataTransferObject Export(string dbName, IEnumerable<string> tableNames)
        {
            throw new System.NotImplementedException();
        }
    }
}
