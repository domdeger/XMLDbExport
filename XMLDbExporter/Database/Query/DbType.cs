using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLDbExporter
{
    public class DbType
    {
        public string DBTypeName
        {
            get;
            set;
        }

        public IEnumerable<Type> PossibleSystemType
        {
            get;
            set;
        }
    }
}
