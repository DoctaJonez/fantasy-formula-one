using System;
using System.Collections.Generic;
using System.Text;

namespace DoctaJonez.FantasyFormulaOne.Data.Dtos
{
    public class Driver
    {
        public string Name { get; set; }
        public int CarNumber { get; set; }
        public Team Team { get; set; }
        public decimal Price { get; set; }
    }
}
