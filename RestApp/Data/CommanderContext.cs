using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    //---> DbContext o sa generezi biblioteca EntityFrameworkCore
    //Conectarea la baza de date
    public class CommanderContext: DbContext
    {
        public CommanderContext (DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Comands { get; set; }
        public object Commands { get; internal set; }
    }
}