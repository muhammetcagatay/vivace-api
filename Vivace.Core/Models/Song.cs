using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivace.Core.Models
{
    public class Song : BaseEntity
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public Category Category { get; set; }
        public Singer Singer { get; set; }
    }
}
