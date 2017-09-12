using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Events
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime BeginDate { get; set; }
        public string Description { get; set; }
    }
}
