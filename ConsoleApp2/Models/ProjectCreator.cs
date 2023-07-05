using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    /*  ProjectCreator
        {Projects} |User| */

    public class ProjectCreator
    {
        public int Id { get; set; }
        public virtual User? User { get; set; }
        public virtual IEnumerable<Projects> Projects { get; set; } = new List<Projects>();
    }
}
