using System;
using System.Collections.Generic;
using XMLDbExporter.Representation;
namespace XMLDbExporter.Core
{
    interface IDatabaseTableRepresentation
    {
        IList<DatabaseRow> Rows { get; set; }
        int TableName { get; set; }
    }
}
