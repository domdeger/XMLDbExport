using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLDbExporter
{
    public class DatabaseTable : XMLDbExporter.IDatabaseTableRepresentation
    {
        public int TableName
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public System.Collections.Generic.IList<XMLDbExporter.IDatabaseRowRepresentation> Rows
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
