using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XMLDbExporter.Core;

namespace XMLDbExporter.Representation
{
    public class DatabaseTable : IDatabaseTableRepresentation
    {
        public int TableName
        {
            get;
            set;
        }

        public System.Collections.Generic.IList<IDatabaseRowRepresentation> Rows
        {
            get;
            set;
        }
    }
}
