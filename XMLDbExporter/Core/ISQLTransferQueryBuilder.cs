using System;
namespace XMLDbExporter
{
    interface ISQLTransferQueryBuilder
    {
        string BuildImportQuery(DataTransferObject o);
    }
}
