using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            return new List<Command>
            {
                new Command
                {
                    Id = 0,
                    HowTo = "Boil an egg",
                    Line = "Boil water",
                    Platform = "Kettle & Pan"
                },
                new Command
                {
                    Id = 1,
                    HowTo = "Cut bread",
                    Line = "Get a knife",
                    Platform = "Knife & Chopping board"
                },
                new Command
                {
                    Id = 3,
                    HowTo = "Make cup of tea",
                    Line = "Place teabag in cup",
                    Platform = "Kettle & Cup"
                }
            };
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "Boil an egg",
                Line = "Boil water",
                Platform = "Kettle & Pan"
            };
        }
    }
}