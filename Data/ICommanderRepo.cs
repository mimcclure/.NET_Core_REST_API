using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data 
{
    public interface ICommanderRepo //not implementing anything in the interface, just defining the operations and methods
    {
        bool SaveChanges();
        
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}