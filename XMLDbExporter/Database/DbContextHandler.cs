using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLDbExporter
{
    public class DbContextHandler : XMLDbExporter.IDbContextHandler
    {
        public XMLDbExporter.DbContextHandlerConfiguration Configuration
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
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
