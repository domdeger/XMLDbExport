using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLDbExporter
{
    public class DbContextHandlerConfiguration
    {
        public System.Uri Host
        {
            get;
            set;
        }

        public XMLDbExporter.DbProtocol Protocol
        {
            get;
            set;
        }

        public int Username
        {
            get;
            set;
        }

        public int Password
        {
            get;
            set;
        }

        public void BuildQueryString()
        {
            throw new System.NotImplementedException();
        }
    }
}
