using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class SuperHeroe : AuditableBaseEntity
    {
        public string SuperHeroeName { get; set; }
        public string LegalName { get; set; }   
        public int Age { get; set; }
        public string SuperPower { get; set; }
        public string Gender { get; set; }
        public string Editorial { get; set; }


        public DateTime 
    }
}
