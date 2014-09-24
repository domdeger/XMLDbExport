using System;
using System.Collections.Generic;
using XMLDbExporter.Representation;
namespace XMLDbExporter.Core
{
    interface IDatabaseRowRepresentation
    {
        int Count { get; set; }
        IList<KeyValueDescription> Values { get; set; }
    }
}
