﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XMLDbExporter.Core;

namespace XMLDbExporter.Representation
{
    public class DataTransferObject
    {
        public int DatabaseSchema
        {
            get;
            set;
        }

        public IList<IDatabaseTableRepresentation> Tables
        {
            get;
            set;
        }
    }
}
