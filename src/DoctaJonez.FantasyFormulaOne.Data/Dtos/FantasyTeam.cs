using System;
using System.Collections.Generic;
using System.Text;

namespace DoctaJonez.FantasyFormulaOne.Data.Dtos
{
    public class FantasyTeam
    {
        public Driver Driver1 { get; set; }
        public Driver Driver2 { get; set; }
        public Team Car1 { get; set; }
        public Team Car2 { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public IEnumerable<FantasyTeamResult> Results { get; set; }
    }
}
