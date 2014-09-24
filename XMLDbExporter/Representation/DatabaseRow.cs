using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLDbExporter
{
    public class DatabaseRow : XMLDbExporter.IDatabaseRowRepresentation
    {
        public System.Collections.Generic.IList<XMLDbExporter.IKeyValueDescription> Values
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Count
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
