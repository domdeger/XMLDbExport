using System;
using XMLDbExporter.Representation;
namespace XMLDbExporter.Core
{
    interface IDbContextHandler
    {
        DbContextHandlerConfiguration Configuration { get; set; }
        DataTransferObject Export(string dbName, System.Collections.Generic.IEnumerable<string> tableNames);
        void Import(DataTransferObject o, string dbName);
    }
}
