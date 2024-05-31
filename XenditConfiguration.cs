using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP
{
    public class XenditConfiguration
    {
        public string ApiKey { get; set; }
        public XenditEnvironment Environment { get; set; }
    }

    public enum XenditEnvironment
    {
        Production,
        Development
    }
}
