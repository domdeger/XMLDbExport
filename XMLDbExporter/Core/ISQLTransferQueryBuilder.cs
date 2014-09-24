using System;
using XMLDbExporter.Representation;
namespace XMLDbExporter.Core
{
    interface ISQLTransferQueryBuilder
    {
        string BuildImportQuery(DataTransferObject o);
    }
}
