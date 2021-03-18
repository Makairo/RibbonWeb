using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RibbonWeb.Models
{
    public class UserLog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserAction { get; set; }
        public string RibbonAction { get; set; }
        public string Date { get; set; }
    }
}
