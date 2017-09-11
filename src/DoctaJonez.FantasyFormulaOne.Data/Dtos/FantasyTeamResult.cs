using System;
using System.Collections.Generic;
using System.Text;

namespace DoctaJonez.FantasyFormulaOne.Data.Dtos
{
    public class FantasyTeamResult
    {
        public FantasyTeam FantasyTeam { get; set; }
        public Race Race { get; set; }
        public decimal Driver1Points { get; set; }
        public decimal Driver2Points { get; set; }
        public decimal Car1Points { get; set; }
        public decimal Car2Points { get; set; }
    }
}
