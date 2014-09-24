using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLDbExporter
{
    public class DataTransferObject
    {
        public int DatabaseSchema
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IList<XMLDbExporter.IDatabaseTableRepresentation> Tables
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
