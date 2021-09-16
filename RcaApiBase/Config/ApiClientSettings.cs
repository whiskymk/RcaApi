using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcaApiBase.Config
{
    public class ApiClientSettings
    {
        public Endpoint Endpoint { get; set; }

    }
    public class Endpoint
    {
        public string Name { get; set; }
        public string BaseAddress { get; set; }
        public string Path { get; set; }
    }
}
