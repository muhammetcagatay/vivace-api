using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivace.Core.Models
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Songs = new HashSet<Song>();
        }
        public string Name { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
