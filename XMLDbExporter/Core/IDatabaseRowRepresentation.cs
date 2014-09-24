using System;
namespace XMLDbExporter
{
    interface IDatabaseRowRepresentation
    {
        int Count { get; set; }
        System.Collections.Generic.IList<KeyValueDescription> Values { get; set; }
    }
}
