using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLDbExporter.Database.Schema
{
    public class DatabaseSchema
    {
        public Encoding Charset { get; set; }
        public IEnumerable<TableDefinition> TableDefinitions { get; set; }
    }
}
