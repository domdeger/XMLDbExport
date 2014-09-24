using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLDbExporter.Database.Schema
{
    public class TableDefinition
    {
        public string Tablename { get; set; }
        public IEnumerable<ColumnDefinition> ColumnDefinitions { get; set; }
    }
}
