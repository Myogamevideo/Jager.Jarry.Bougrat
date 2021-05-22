using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entity
{
    public class Formation
    {
        public int Id { get; set; }
        public int FkEmployee { get; set; }
        public Employee Employee { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}
