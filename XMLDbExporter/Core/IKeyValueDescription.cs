using System;
namespace XMLDbExporter.Core
{
    interface IKeyValueDescription
    {
        int DBValueType { get; set; }
        string Key { get; set; }
        object Value { get; set; }
    }
}
