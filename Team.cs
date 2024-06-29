using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Team
    {

        private readonly List<Person> _firstTeam;
        private readonly List<Person> _reserveTeam;
        
        public string Name { get; }
        public IReadOnlyCollection<Person> FirstTeam => _firstTeam.AsReadOnly();
        public IReadOnlyCollection<Person> ReserveTeam => _reserveTeam.AsReadOnly();   

        public Team(string name)
        {
            Name = name;
            _firstTeam = new List<Person>();
            _reserveTeam = new List<Person>();
        }
        public void AddPlayer(Person person)
        {
            if (person.Age < 40) _firstTeam.Add(person);
            else _reserveTeam.Add(person);
        }
        public override string ToString() =>
        $"First team has {FirstTeam.Count} players.{Environment.NewLine}Reserve team has {ReserveTeam.Count} players.";
    }
}
