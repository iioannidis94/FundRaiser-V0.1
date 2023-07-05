﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    /* Category
     * |Projects| */

    public class Category
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public virtual Project? Projects { get; set; }

    }
}
