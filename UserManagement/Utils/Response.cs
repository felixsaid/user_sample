using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.Utils
{
    public class Response
    {
        public bool error { get; set; }
        public object data { get; set; }
        public string message { get; set; }
    }
}
