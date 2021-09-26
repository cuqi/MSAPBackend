using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ApiBackend.Models
{
    public class Location
    {
        public long ID { get; set; }
        public double x { get; set; }
        public double y { get; set; }
    }
}
