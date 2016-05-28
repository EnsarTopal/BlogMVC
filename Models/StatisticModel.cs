using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class StatisticModel
    {
        public int BlogCount { get; set; }

        public List<Blog> Blogi { get; set; }
    }
}