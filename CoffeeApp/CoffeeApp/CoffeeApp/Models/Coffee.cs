using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeApp.Models
{
    class Coffee
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public bool MadeAtHome { get; set; }
        public string Location { get; set; }
        public string OS { get; set; }

    }
}
