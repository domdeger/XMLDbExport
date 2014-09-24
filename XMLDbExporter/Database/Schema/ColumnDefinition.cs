using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLDbExporter.Database.Schema
{
    public class ColumnDefinition
    {
        public string ColumnName { get; set; }
        public DbType DatabaseType { get; set; }
    }
}
