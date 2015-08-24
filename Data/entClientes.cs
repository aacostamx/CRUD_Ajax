using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class entClientes
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public entClientes()
        {
            CustomerId = 0;
            Name = string.Empty;
            Country = string.Empty;
        }
    }
}
