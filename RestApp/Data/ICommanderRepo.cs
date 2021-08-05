using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
    //Interfata app
{
    public interface ICommanderRepo
    {
        object Comands { get; }

        bool SaveChanges();
        // IEnumerable<Command> GetAppComands();

        IEnumerable<Command> GetAllComands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);

        // object GetAllCommands();
    }
}
