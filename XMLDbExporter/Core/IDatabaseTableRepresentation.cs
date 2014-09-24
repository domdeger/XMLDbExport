using System;
namespace XMLDbExporter
{
    interface IDatabaseTableRepresentation
    {
        System.Collections.Generic.IList<DatabaseRow> Rows { get; set; }
        int TableName { get; set; }
    }
}
