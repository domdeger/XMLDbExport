using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XMLDbExporter.Core;

namespace XMLDbExporter.Representation
{
    public class DatabaseRow : IDatabaseRowRepresentation
    {
        public System.Collections.Generic.IList<IKeyValueDescription> Values
        {
            get;
            set;
        }

        public int Count
        {
            get;
            set;
        }
    }
}
