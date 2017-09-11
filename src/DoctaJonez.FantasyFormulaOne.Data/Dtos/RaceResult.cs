using System;
using System.Collections.Generic;
using System.Text;

namespace DoctaJonez.FantasyFormulaOne.Data.Dtos
{
    public class RaceResult
    {
        public Driver Driver { get; set; }
        public Team Team { get; set; }
        public int Position { get; set; }
        public TimeSpan Time { get; set; }
        public int Laps { get; set; }
        public decimal Points { get; set; }
    }
}
