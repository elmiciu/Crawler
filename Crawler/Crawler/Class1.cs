using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
    class Class1
    {
        private int _myProperty;
        public int MyProperty { 
            get { return _myProperty * 15; } 
            set { _myProperty = value; } 
        }
        public int MyProperty2 { get; set; }
    }
}
