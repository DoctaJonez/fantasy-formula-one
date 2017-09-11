using System;
using System.Collections.Generic;
using System.Text;

namespace DoctaJonez.FantasyFormulaOne.Data.Dtos
{
    public class Race
    {
        public string Name { get; set; }
        public int Round { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<QualifyingResult> QualifyingResults { get; set; }
        public IEnumerable<RaceResult> RaceResults { get; set; }
    }
}
