using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo //MockCommanderRepo implements the interface
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {

            var commands = new List<Command>
            {   
                //mock command objects
                new Command{Id=0, HowTo="1", Line="2", Platform="3"},
                new Command{Id=1, HowTo="4", Line="5", Platform="6"},
                new Command{Id=2, HowTo="7", Line="8", Platform="9"}
            };

            return commands;
        }

        public Command GetCommandById(int id) //can accept id but isn't going to do anything w/ it
        {
        
            return new Command{Id=0, HowTo="1", Line="2", Platform="3"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}