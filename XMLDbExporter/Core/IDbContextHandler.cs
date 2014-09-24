using System;
namespace XMLDbExporter
{
    interface IDbContextHandler
    {
        DbContextHandlerConfiguration Configuration { get; set; }
        DataTransferObject Export(string dbName, System.Collections.Generic.IEnumerable<string> tableNames);
        void Import(DataTransferObject o, string dbName);
    }
}
