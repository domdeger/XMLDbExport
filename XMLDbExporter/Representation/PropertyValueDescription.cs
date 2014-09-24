using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XMLDbExporter.Core;

namespace XMLDbExporter.Representation
{
    public class KeyValueDescription : IKeyValueDescription
    {
        private string _key;
        private object _value;
        private DbType _dbValueType;
        public string Key
        {
            get
            {
                return _key;
            }
            set
            {
                _key = value;
            }
        }

        public object Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public DbType DBValueType
        {
            get
            {
                return _dbValueType;
            }
            set
            {
                _dbValueType = value;
            }
        }
    }
}
