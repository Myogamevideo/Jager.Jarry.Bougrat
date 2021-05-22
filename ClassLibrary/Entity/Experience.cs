using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entity
{
    public class Experience
    {
        public int Id { get; set; }
        public int FkEmployee { get; set; }
        public Employee Employee { get; set; }
        public string title { get; set; }
        public DateTime Date { get; set; }
    }
}
