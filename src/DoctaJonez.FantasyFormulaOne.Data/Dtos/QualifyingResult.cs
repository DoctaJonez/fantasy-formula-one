using System;
using System.Collections.Generic;
using System.Text;

namespace DoctaJonez.FantasyFormulaOne.Data.Dtos
{
    public class QualifyingResult
    {
        public Driver Driver { get; set; }
        public Team Team { get; set; }
        public int Position { get; set; }
        public TimeSpan Q1Time { get; set; }
        public TimeSpan Q2Time { get; set; }
        public TimeSpan Q3Time { get; set; }
        public int Laps { get; set; }
        public decimal Points { get; set; }
    }
}
