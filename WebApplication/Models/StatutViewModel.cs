using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class StatutViewModel
    {
        public int Id { get; set; }

        public string Label { get; set; }

        public StatutViewModel() {}

        public StatutViewModel(int id, string label)
        {
            Id = id;
            Label = label;
        }
    }
}