using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopmentTechnicalTestFrontEnd.Models
{
    public class Payment
    {
        public string To { get; set; }

        public string From { get; set; }

        public decimal Amount { get; set; }

        public DateTime DateToSend { get; set; }
    }
}
