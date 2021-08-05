using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public object Comands => throw new NotImplementedException();

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Comands.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Comands.Remove(cmd);
        }

        public IEnumerable<Command> GetAllComands()
        {
            return _context.Comands.ToList();
            //throw new System.NotImplementedException();
        }

        public object GetAllCommands()
        {
            throw new System.NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            return _context.Comands.FirstOrDefault(p => p.Id == id);
            //throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command cmd)
        {
            //Nothing
        }
    }
}