using System;
namespace XMLDbExporter
{
    interface IKeyValueDescription
    {
        int DBValueType { get; set; }
        string Key { get; set; }
        object Value { get; set; }
    }
}
