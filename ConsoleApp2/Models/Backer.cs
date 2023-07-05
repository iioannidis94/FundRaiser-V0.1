using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    /*  Backer
        {ProjectFunding} |User|*/

    public class Backer
    {
        public int Id { get; set; }
        public virtual User? User { get; set; }
        public virtual IEnumerable<ProjectFunding> ProjectFundings { get; set; } = new List<ProjectFunding>();
    }
}
