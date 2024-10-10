using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Models
{
    public class Asset : DomainObject
    {
        public virtual Account Account { get; set; }
        public virtual Stock Stock { get; set; }
        public int Shares { get; set; }

    }
}
