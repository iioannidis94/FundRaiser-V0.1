using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    /* ProjectVideos
     * |Projects| */

    public class ProjectVideos
    {
        public int Id { get; set; }
        public string? VideoName { get; set; }
        public virtual Projects? Projects { get; set; }
    }
}
